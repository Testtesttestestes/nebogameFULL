using System;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using UI.Rewards;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public class CollectionToolTipView : BaseToolTip<CollectionToolTipVO>
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x5D0F", Offset = "0x5D0F", VA = "0x5D0F", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_CollectionToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_CollectionToolTipVO___ctor__);
		    DAT_ram_00a5b8e5 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_CollectionToolTipVO___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x5D10", Offset = "0x5D10", VA = "0x5D10")]
		public CollectionToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_CollectionToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5b8e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IslandBossMonsterToolTipVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IslandBossMonsterToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a5b8e6 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    UI_ToolTip_BaseToolTip_object___get_Data
		              (*(undefined4 *)(param1 + 0x18),*(int *)(param1 + 0x14),
		               Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO__set_Data__);
		    param1_01 = *(undefined4 *)(param1 + 0x1c);
		    iVar1 = *(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x14) + 8);
		    param2_00 = *(undefined4 *)(iVar1 + 8);
		    param4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x30) + 0x10) + 0x14);
		    param1_00 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		              (param1_00,param2_00,param2_00,param4,0);
		    UI_Requirements_RequirementsView__get_Data(param1_01,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/CollectionToolTipView";

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CollectionView _header;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
