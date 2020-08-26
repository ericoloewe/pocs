import de.hybris.platform.core.Registry;
import de.hybris.platform.commerceservices.search.flexiblesearch.PagedFlexibleSearchService;
import de.hybris.platform.util.Config;
import de.hybris.platform.commerceservices.search.pagedata.PageableData;
import de.hybris.platform.servicelayer.search.FlexibleSearchQuery;
import java.util.stream.Collectors;

final String QUERY = "select {pk} from {PointOfService}";
def folder = Config.getParameter("localenv.storage.out.dir")
def file = """${folder}/temp/point-of-services.txt"""
def pageable = new PageableData() {{
	setPageSize(1000)
	setCurrentPage(0)
}}
def pagedFlexibleSearchService = Registry.getApplicationContext().getBean("pagedFlexibleSearchService", PagedFlexibleSearchService.class)
def result = pagedFlexibleSearchService.search(new FlexibleSearchQuery(QUERY), pageable)

println Config.getParameter("localenv.storage.out.dir")
println result.getResults()

while (pageable.getCurrentPage() <= result.getPagination().getNumberOfPages()) {  
  BufferedWriter bufferedWriter = null;

  try {
    bufferedWriter = new BufferedWriter(new FileWriter(file, true))
    
    result.getResults().stream().map({p -> p.getPk()}).forEach({pk -> 
      bufferedWriter.append(pk.toString());
    });
  } catch (IOException ex) {
    println ex;
  }
  
  bufferedWriter.close();
  
  pageable.setCurrentPage(pageable.getCurrentPage() + 1);
  result = pagedFlexibleSearchService.search(new FlexibleSearchQuery(QUERY), pageable)
}