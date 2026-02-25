using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Placements.Base.Model
{
	// Token: 0x0200121B RID: 4635
	[Token(Token = "0x200121B")]
	public abstract class AbstractAdPlacementModel : AbstractModel
	{
		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06006DD0 RID: 28112 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x1700164B")]
		public uint AdPlacementId
		{
			[Token(Token = "0x6006DD0")]
			[Address(RVA = "0xB88F", Offset = "0xB88F", VA = "0xB88F")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0xB890", Offset = "0xB890", VA = "0xB890")]
		protected AbstractAdPlacementModel(UserData user, IAdPlacementData placementData)
		{
		}

		// Token: 0x04003977 RID: 14711
		[Token(Token = "0x4003977")]
		[FieldOffset(Offset = "0xC")]
		public readonly IAdPlacementData PlacementData;
	}
}
