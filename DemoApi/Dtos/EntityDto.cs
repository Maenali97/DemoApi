using Domain;

namespace DemoApi
{

        [Serializable]
        public abstract class EntityDto : IEntityDto //TODO: Consider to delete this class
        {
            public override string ToString()
            {
                return $"[DTO: {GetType().Name}]";
            }
        }


        [Serializable]
        public abstract class EntityDto<TKey> : EntityDto, IEntity<TKey>
        {
            public virtual TKey Id { get; protected set; }

            protected EntityDto()
            {

            }

            protected EntityDto(TKey id)
            {
                Id = id;
            }

            //public override object[] GetKeys()
            //{
            //    return new object[] { Id };
            //}

            public override string ToString()
            {
                return $"[ENTITY: {GetType().Name}] Id = {Id}";
            }
        }
    }