using System.Collections;

namespace OilsPro.Services
{
    public interface INomenclaturesService
    {
        int GetRecordings(string entityName);
        ICollection All(string entityType);
    }
}
