using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace UI.Filters
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	public class MetaFilterToggleView : AbstractFilterToggleView<MetaFilterData<ArtikulTypeMetaFilterDic, ArtikulTypeFilters>>
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x5F8B", Offset = "0x5F8B", VA = "0x5F8B", Slot = "5")]
		public override void Init(MetaFilterData<ArtikulTypeMetaFilterDic, ArtikulTypeFilters> filter)
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x5F8C", Offset = "0x5F8C", VA = "0x5F8C", Slot = "7")]
		protected override void ToggleValueChangedEventHandler(bool isOn)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x5F8D", Offset = "0x5F8D", VA = "0x5F8D", Slot = "6")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x5F8E", Offset = "0x5F8E", VA = "0x5F8E")]
		public MetaFilterToggleView()
		{
		}
	}
}
