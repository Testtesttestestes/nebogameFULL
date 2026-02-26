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
		/* --- GHIDRA: Init ---
		void UI_Filters_MetaFilterToggleView__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6392a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___ToggleValueChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_Data__
		              );
		    DAT_ram_00a6392a = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x18) + 8);
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (param2 == 0) {
		    uVar1 = Core_Extensions_Dict_ArtikulTypeMetaFilterDicExt__GetIconEnabled(uVar1,0);
		  }
		  else {
		    uVar1 = Core_Extensions_Dict_ArtikulTypeMetaFilterDicExt__GetTitle(uVar1,0);
		  }
		  AssetContent_GameImage__get_AssetId(param1_00,uVar1,0);
		  UnityEngine_UIElements_ReusableCollectionItem__SetDragGhost
		            (param1,param2,
		             Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___ToggleValueChangedEventHandler__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x5F8C", Offset = "0x5F8C", VA = "0x5F8C", Slot = "7")]
		protected override void ToggleValueChangedEventHandler(bool isOn)
		{
		/* --- GHIDRA: ToggleValueChangedEventHandler ---
		int UI_Filters_MetaFilterToggleView__ToggleValueChangedEventHandler(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_02;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6392b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters___get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ArtikulTypeFilters__string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ToolTip_Implementations_View_TitleWhitListToolTipView_TitleWhitListToolTipData_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_ToolTipData_TitleWhitListToolTipView_TitleWhitListToolTipData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_ToolTipData_TitleWhitListToolTipView_TitleWhitListToolTipData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_ToolTip_ToolTipData_TitleWhitListToolTipView_TitleWhitListToolTipData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Filters_MetaFilterToggleView___c__GetData_b__2_0__);
		    Mono_Security_ASN1__get_Item(&UI_Filters_MetaFilterToggleView___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12542);
		    DAT_ram_00a6392b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_ToolTip_ToolTipData_TitleWhitListToolTipView_TitleWhitListToolTipData__TypeInfo
		                        );
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12542,
		             Method_UI_ToolTip_ToolTipData_TitleWhitListToolTipView_TitleWhitListToolTipData___ctor__
		            );
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_ToolTip_Implementations_View_TitleWhitListToolTipView_TitleWhitListToolTipData_TypeInfo
		                        );
		  UI_ToolTip_Implementations_View_TitleWhitListToolTipView___ctor(param1_01,0);
		  uVar1 = Core_Extensions_Dict_ArtikulTypeMenuActionDicExt__GetRequirementMessage
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 8),0);
		  *(undefined4 *)(param1_01 + 8) = uVar1;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc);
		  if (*(int *)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Filters_MetaFilterToggleView___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x5c);
		  param1_02 = puVar2[1];
		  if (param1_02 == 0) {
		    if (*(int *)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Filters_MetaFilterToggleView___c_TypeInfo);
		      puVar2 = *(undefined4 **)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_02 = unnamed_function_1417(System_Func_ArtikulTypeFilters__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_02,param2_00,Method_UI_Filters_MetaFilterToggleView___c__GetData_b__2_0__,0);
		    *(int *)(*(int *)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x5c) + 4) = param1_02;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_02,
		                     Method_System_Linq_Enumerable_Select_ArtikulTypeFilters__string___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_string___);
		  *(undefined4 *)(param1_01 + 0xc) = uVar1;
		  *(int *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x5F8D", Offset = "0x5F8D", VA = "0x5F8D", Slot = "6")]
		public override BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void UI_Filters_MetaFilterToggleView__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6392c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters____ctor__
		              );
		    DAT_ram_00a6392c = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_Filters_AbstractFilterToggleView_MetaFilterData_ArtikulTypeMetaFilterDic__ArtikulTypeFilters____ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x5F8E", Offset = "0x5F8E", VA = "0x5F8E")]
		public MetaFilterToggleView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_MetaFilterToggleView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6392d == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Filters_MetaFilterToggleView___c_TypeInfo);
		    DAT_ram_00a6392d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Filters_MetaFilterToggleView___c_TypeInfo);
		  **(undefined4 **)(UI_Filters_MetaFilterToggleView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
