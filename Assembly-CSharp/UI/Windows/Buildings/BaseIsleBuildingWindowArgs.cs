using System;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	public abstract class BaseIsleBuildingWindowArgs<TIsle> : BaseWindowArgs
	{
		// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001001")]
		protected BaseIsleBuildingWindowArgs(TIsle isle, uint buildingTypeId)
		{
		}

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x0")]
		public TIsle Isle;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x0")]
		public uint BuildingTypeId;
	}
}
