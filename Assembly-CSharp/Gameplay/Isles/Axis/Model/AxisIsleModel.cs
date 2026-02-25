using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Base.Model;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;

namespace Gameplay.Isles.Axis.Model
{
	// Token: 0x02000D07 RID: 3335
	[Token(Token = "0x2000D07")]
	public class AxisIsleModel : BaseIsleModel
	{
		// Token: 0x06005168 RID: 20840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005168")]
		[Address(RVA = "0x9F47", Offset = "0x9F47", VA = "0x9F47")]
		public AxisIsleModel(UserData user, ulong id, IDictProvider dictionaries, IGame game)
		{
		}

		// Token: 0x04002C53 RID: 11347
		[Token(Token = "0x4002C53")]
		[FieldOffset(Offset = "0x30")]
		public readonly WorldAxisModel WorldAxisModel;
	}
}
