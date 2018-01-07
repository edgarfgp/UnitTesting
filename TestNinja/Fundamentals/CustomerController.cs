namespace TestNinja.Fundamentals
{
    public class CustomerController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id of Customer</param>
        /// <returns>This method returns if was Found</returns>
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();
            
            return new Ok();
        }        
    }
    
    public class ActionResult { }
    
    public class NotFound : ActionResult { }
 
    public class Ok : ActionResult { }
}