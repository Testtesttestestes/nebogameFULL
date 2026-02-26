using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000942 RID: 2370
	[Token(Token = "0x2000942")]
	public class CombatElixirButtonV2 : CombatSpellButton
	{
		// Token: 0x06003814 RID: 14356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003814")]
		[Address(RVA = "0x87CB", Offset = "0x87CB", VA = "0x87CB", Slot = "8")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Spells_CombatElixirButtonV2__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a566e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a566e1 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x4c) + 0x2c) != 0) {
		    piVar2 = *(int **)(param1 + 0x60);
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x3c);
		    iVar1 = func_ii_4443(&local_4,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(0 < *(int *)(*(int *)(param1 + 0x4c) + 0x3c)),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003815")]
		[Address(RVA = "0x87CC", Offset = "0x87CC", VA = "0x87CC", Slot = "15")]
		public override void UpdateCount()
		{
		/* --- GHIDRA: UpdateCount ---
		void Gameplay_Combat_View_Spells_CombatElixirButtonV2__UpdateCount(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a566e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a566e2 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x4c) + 0x2c);
		  if (iVar1 != 0) {
		    param1_00 = Core_Extensions_Dict_AprMarkerDicExt__GetTitle
		                          (*(undefined4 *)(*(int *)(iVar1 + 8) + 0x10),0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_00,0);
		    if (iVar1 == 0) {
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		                (*(undefined4 *)(param1 + 0x20),param1_00,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x87CD", Offset = "0x87CD", VA = "0x87CD", Slot = "16")]
		protected override void LoadImage()
		{
		/* --- GHIDRA: LoadImage ---
		void Gameplay_Combat_View_Spells_CombatElixirButtonV2__LoadImage(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a566e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleEnabledChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Enabled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_MaskOnTop__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566e3 = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___HandleDataChanged
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleEnabledChanged__
		            );
		  param2_00 = 0.0;
		  if (*(char *)(param1 + 0x49) == '\0') {
		    param2_00 = 1.0;
		  }
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x5c),param2_00,0);
		  param1_00 = *(undefined4 *)(param1 + 0x44);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    UnityEngine_UI_MaskUtilities__Notify2DMaskStateChanged(*(undefined4 *)(param1 + 0x44),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x87CE", Offset = "0x87CE", VA = "0x87CE", Slot = "14")]
		protected override void HandleEnabledChanged()
		{
		/* --- GHIDRA: HandleEnabledChanged ---
		void Gameplay_Combat_View_Spells_CombatElixirButtonV2__HandleEnabledChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a566e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__Start__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566e4 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x5c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1c0) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x1c4));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_5950(uVar1,Method_UnityEngine_Object_Instantiate_Material___);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1c8) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x1cc));
		  UnityEngine_UI_Selectable__OnEnable
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__Start__);
		  return;
		}
		*/

		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x87CF", Offset = "0x87CF", VA = "0x87CF")]
		protected new void Start()
		{
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003819")]
		[Address(RVA = "0x87D0", Offset = "0x87D0", VA = "0x87D0")]
		public CombatElixirButtonV2()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Combat_View_Spells_CombatElixirButtonV2___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a566e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_CombatSpellData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_CombatSpellData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_CombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12533);
		    DAT_ram_00a566e5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_CombatSpellData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12533,Method_UI_ToolTip_ToolTipData_CombatSpellData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x4c);
		  return param1_00;
		}
		*/

		}

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _artifactQualityImage;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _countTextField;
	}
}
