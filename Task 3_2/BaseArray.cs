using System;
namespace fpgiuh
{
	public abstract class BaseArray
	{
		protected BaseArray(bool fillArray_by_User)
		{
			Create(fillArray_by_User);
		}

        protected abstract void fill_RandomArray();
        protected abstract void fillArray_by_User();

        public abstract void PrintArray();

        public abstract void Create(bool fillArray_by_User);

		public abstract decimal Average_Value();

    }
}

