using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000941 RID: 2369
	[Token(Token = "0x2000941")]
	public class CombatElixirButton : CombatSpellButton
	{
		// Token: 0x0600380E RID: 14350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380E")]
		[Address(RVA = "0x87C5", Offset = "0x87C5", VA = "0x87C5", Slot = "8")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Spells_CombatElixirButton__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a566dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a566dc = '\x01';
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
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380F")]
		[Address(RVA = "0x87C6", Offset = "0x87C6", VA = "0x87C6", Slot = "15")]
		public override void UpdateCount()
		{
		/* --- GHIDRA: UpdateCount ---
		void Gameplay_Combat_View_Spells_CombatElixirButton__UpdateCount(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a566dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a566dd = '\x01';
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

		// Token: 0x06003810 RID: 14352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003810")]
		[Address(RVA = "0x87C7", Offset = "0x87C7", VA = "0x87C7", Slot = "16")]
		protected override void LoadImage()
		{
		/* --- GHIDRA: LoadImage ---
		void Gameplay_Combat_View_Spells_CombatElixirButton__LoadImage(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a566de == '\0') {
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
		    DAT_ram_00a566de = '\x01';
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

		// Token: 0x06003811 RID: 14353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x87C8", Offset = "0x87C8", VA = "0x87C8", Slot = "14")]
		protected override void HandleEnabledChanged()
		{
		/* --- GHIDRA: HandleEnabledChanged ---
		void Gameplay_Combat_View_Spells_CombatElixirButton__HandleEnabledChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a566df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__Start__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Material___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a566df = '\x01';
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

		// Token: 0x06003812 RID: 14354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x87C9", Offset = "0x87C9", VA = "0x87C9")]
		protected new void Start()
		{
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x87CA", Offset = "0x87CA", VA = "0x87CA")]
		public CombatElixirButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Spells_CombatElixirButton___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a566e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a566e0 = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___GetData
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__HandleDataChanged__
		            );
		  if (*(int *)(param1[0x13] + 0x2c) != 0) {
		    uVar2 = Core_Extensions_Dict_ArtikulDicExt__GetPetIconAssetId
		                      (*(undefined4 *)(*(int *)(*(int *)(param1[0x13] + 0x2c) + 8) + 0x10),0);
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		    if (iVar1 != 0) {
		      uVar2 = Core_Extensions_Dict_IsleInfoDictExt__GetBackgroundImageAssetId
		                        (*(undefined4 *)(*(int *)(param1[0x13] + 0x2c) + 0x14),0);
		    }
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[0x17],uVar2,0);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  if (param1[0x13] == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(*(int *)(param1[0x13] + 0x38) != 0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))(param1,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _artifactQualityImage;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _countTextField;
	}
}
