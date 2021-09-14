using Fundamentos.Data.VO;
using Fundamentos.Hypermedia.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Hypermedia.Enricher
{
    public class PersonEnricher : ContentResponseEnricher<PersonVO>
    {
        // Execução ocorrerá com paralelismo e para evitar erro é necessário lockar os objetos
        private readonly object _lock = new object();

        protected override Task EnrichModel(PersonVO content, IUrlHelper urlHelper)
        {
            var path = "api/person/v1";
            string link = GetLink(content.Id, urlHelper, path);
            
            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPut
            });

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.DELETE,
                Href = link,
                Rel = RelationType.self,
                Type = "int"
            });

            content.Links.Add(new HyperMediaLink()
            {
            Action = HttpActionVerb.PATCH,
            Href = link,
            Rel = RelationType.self,
            Type = ResponseTypeFormat.DefaultPatch
            });
            return null;
        }

        private string GetLink(long id, IUrlHelper urlhelper, string path)
        {
            lock (_lock)
            {
                var url = new { controller = path, id = id };
                return new StringBuilder(urlhelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            }
        }
    }
}
