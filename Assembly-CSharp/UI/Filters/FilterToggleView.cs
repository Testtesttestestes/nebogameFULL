using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace UI.Filters
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	public class FilterToggleView : AbstractFilterToggleView<ArtikulTypeFilters>
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x5F73", Offset = "0x5F73", VA = "0x5F73", Slot = "5")]
		public override void Init(ArtikulTypeFilters filter)
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x5F74", Offset = "0x5F74", VA = "0x5F74", Slot = "7")]
		protected override void ToggleValueChangedEventHandler(bool isOn)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x5F75", Offset = "0x5F75", VA = "0x5F75", Slot = "6")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x5F76", Offset = "0x5F76", VA = "0x5F76")]
		public FilterToggleView()
		{
		}
	}
}
