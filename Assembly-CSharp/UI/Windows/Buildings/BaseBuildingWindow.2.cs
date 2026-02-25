using System;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A5 RID: 677
	[Token(Token = "0x20002A5")]
	public abstract class BaseBuildingWindow<T, YIsle> : ClosableBaseWindow<T> where T : BaseIsleBuildingWindowArgs<YIsle>
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000FFB RID: 4091
		[Token(Token = "0x17000243")]
		protected abstract BaseBuildingInfoView<YIsle> BuildingInfoView { [Token(Token = "0x6000FFB")] get; }

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFC")]
		protected override void OnShow(T args)
		{
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFD")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFE")]
		protected BaseBuildingWindow()
		{
		}
	}
}
