using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Walsun.Erp.CmskitService.EntityFrameworkCore;

[ConnectionStringName(CmskitServiceDbProperties.ConnectionStringName)]
public interface ICmskitServiceDbContext : IEfCoreDbContext
{
}