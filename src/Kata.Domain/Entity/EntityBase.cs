namespace Kata.Domain.Entity {
    public class EntityBase {
        public int Id { get; set; }

        public override bool Equals(object obj){
            if(Id == 0)
                return false;            

            var entity = obj as EntityBase;

            if(entity == null)
                return false;

            return entity.Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}