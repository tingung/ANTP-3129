using System;

public class Class1
{
    [HttpPost]
    public HttpResponseMessage UpdateUserSettings()
    {
        return Request.CreateResponse(HttpStatusCode.OK, new { });
    }
    
}
