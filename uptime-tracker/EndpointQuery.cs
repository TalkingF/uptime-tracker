public class EndpointQuery
{
    private HttpClient http = new HttpClient();

    public async Task<bool> TestEnpoint(Uri endpoint)
    {
        using (HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Head, endpoint))
        {
            try
            {
                using (HttpResponseMessage response = await http.SendAsync(req))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                
            }
            
  
            
        }

    }
}
