using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public abstract class BaseBuildingData<T> : BaseBuildingData where T : Enum
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060013C3 RID: 5059
		[Token(Token = "0x17000313")]
		public abstract T Type { [Token(Token = "0x60013C3")] get; }

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C4")]
		protected BaseBuildingData(Dictionaries dictionaries)
		{
		}
	}
}
