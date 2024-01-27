

namespace webAPI2
{
    [route("api/[controller]")]
    [APIController]
    public class EmployeeController : Controller
    {
        [httpPost]
        public void Post([fromBody] MEmployee employee)
        {
            using (var _context = new EmployeeContext())
            {
                _context.mEmployees.Add(employee);
                _context.SaveChanges();
            }
        }

        [httpGet]
        public list<MEmployee> Get()
        {
            using (var _context = new EmployeeContext())
            {
                return mEmployees.ToList();
            }
        }

        [httpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new EmployeeContext())
            {
                var item = _context.mEmployees.FirstOrDefault(t => t.EmpId == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [httpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new EmployeeContext())
            {
                var item = _context.mEmployees.FirstOrDefault(t => t.EmpId == id);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
    }
}
