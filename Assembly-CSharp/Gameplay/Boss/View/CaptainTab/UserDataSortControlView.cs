using System;
using System.Collections.Generic;
using Core.Data;
using Core.Sorting;
using Il2CppDummyDll;
using UI.Sorting;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	public class UserDataSortControlView : AbstractSortControlView<UserData>
	{
		// Token: 0x060047B9 RID: 18361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x9644", Offset = "0x9644", VA = "0x9644", Slot = "4")]
		protected override List<IGameDataComparer<UserData>> GetComparers()
		{
			return null;
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x9645", Offset = "0x9645", VA = "0x9645")]
		public UserDataSortControlView()
		{
		}
	}
}
