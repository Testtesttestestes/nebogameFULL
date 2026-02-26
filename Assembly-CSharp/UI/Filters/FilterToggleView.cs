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
		/* --- GHIDRA: Init ---
		void UI_Filters_FilterToggleView__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6391a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__ToggleValueChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_Data__);
		    DAT_ram_00a6391a = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (param2 == 0) {
		    param2_00 = Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetIconEnabled
		                          (*(undefined4 *)(param1 + 0x18),0);
		  }
		  else {
		    param2_00 = Core_Extensions_Dict_ArtikulTypeDicExt__GetDismantleRestrictionsTitle
		                          (*(undefined4 *)(param1 + 0x18),0);
		  }
		  AssetContent_GameImage__get_AssetId(param1_00,param2_00,0);
		  UnityEngine_UIElements_ReusableCollectionItem__SetDragGhost
		            (param1,param2,
		             Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__ToggleValueChangedEventHandler__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x5F74", Offset = "0x5F74", VA = "0x5F74", Slot = "7")]
		protected override void ToggleValueChangedEventHandler(bool isOn)
		{
		/* --- GHIDRA: ToggleValueChangedEventHandler ---
		int UI_Filters_FilterToggleView__ToggleValueChangedEventHandler(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6391b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    DAT_ram_00a6391b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  uVar1 = Gameplay_Inventory_View_Chest_ArtifactCategoryData___ctor
		                    (*(undefined4 *)(param1 + 0x18),0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x5F75", Offset = "0x5F75", VA = "0x5F75", Slot = "6")]
		public override BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void UI_Filters_FilterToggleView__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6391c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters___ctor__);
		    DAT_ram_00a6391c = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters___ctor__);
		  return;
		}
		*/

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
