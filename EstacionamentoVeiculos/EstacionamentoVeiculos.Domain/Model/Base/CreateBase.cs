using System;

namespace EstacionamentoVeiculos.Domain.Model.Base
{
    public class CreateBase : BaseModel
    {
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
