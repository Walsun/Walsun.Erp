using Volo.Abp.Modularity;

namespace Walsun.Erp.CmskitService;

[DependsOn(
    typeof(CmskitServiceApplicationModule),
    typeof(CmskitServiceDomainTestModule)
    )]
public class CmskitServiceApplicationTestModule : AbpModule
{

}
