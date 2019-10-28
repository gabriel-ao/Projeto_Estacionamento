using System;

namespace EstacionamentoVeiculos.Infra.Entities.Base
{
    public class EntityComplexBase : EntityBase
    {
        public DateTimeOffset  CreateDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public bool Active { get; set; }

    }
}
