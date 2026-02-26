using System;
using System.Collections.Generic;
using Core.Data.Effect;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.VortexCombat.View.Player
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	public class LongEffect : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public List<EffectData> Effects
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x67AE", Offset = "0x67AE", VA = "0x67AE")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015ED")]
			[Address(RVA = "0x67AF", Offset = "0x67AF", VA = "0x67AF")]
			set
			{
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x67B0", Offset = "0x67B0", VA = "0x67B0")]
		private void HandleEffectsChanged()
		{
		/* --- GHIDRA: HandleEffectsChanged ---
		int Gameplay_VortexCombat_View_Player_LongEffect__HandleEffectsChanged(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5821e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_EffectData_____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_EffectData____set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_EffectData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12545);
		    DAT_ram_00a5821e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_EffectData____TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12545,Method_UI_ToolTip_ToolTipData_EffectData_____ctor__);
		  uVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_List_EffectData__ToArray__);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x67B1", Offset = "0x67B1", VA = "0x67B1", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x67B2", Offset = "0x67B2", VA = "0x67B2")]
		public LongEffect()
		{
		}

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _count;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x14")]
		private List<EffectData> _effects;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Effects ---
		void Gameplay_VortexCombat_View_Player_LongEffect__get_Effects
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (*(int *)(param1 + 0x14) != param2) {
		    *(int *)(param1 + 0x14) = param2;
		    if (DAT_ram_00a5821d == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Count__);
		      Mono_Security_ASN1__get_Item(&StringLiteral_28377);
		      DAT_ram_00a5821d = '\x01';
		      param2 = *(int *)(param1 + 0x14);
		    }
		    if (param2 != 0) {
		      piVar2 = *(int **)(param1 + 0x10);
		      local_4 = *(undefined4 *)(param2 + 0xc);
		      uVar1 = func_ii_4443(&local_4,0);
		      uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_28377,0);
		      iVar3 = *piVar2;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Effects ---
		void Gameplay_VortexCombat_View_Player_LongEffect__set_Effects(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5821d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28377);
		    DAT_ram_00a5821d = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    piVar2 = *(int **)(param1 + 0x10);
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc);
		    uVar1 = func_ii_4443(&local_4,0);
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_28377,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_StackField ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__get_StackField
		               (int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__StopAllTweens(*(undefined4 *)(param1 + 0x30),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x34)) {
		    *(int *)(param1 + 0x34) = param2;
		    Gameplay_Combat_View_Players_LongEffects_LongEffect__set_Data(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__set_Data(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  int local_4;
		  
		  if (param1[0xd] != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		              (param1,param1[0xd],*(undefined4 *)(*param1 + 0xec));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		              (param1,param1[0xd],*(undefined4 *)(*param1 + 0xf4));
		    piVar3 = (int *)param1[5];
		    iVar4 = param1[0xb];
		    uVar1 = func_ii_4443(param1[0xd] + 0x18,0);
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(iVar4,uVar1,0);
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		              (param1,param1[0xd],*(undefined4 *)(*param1 + 0xfc));
		    iVar4 = *(int *)(param1[0xd] + 0x1c);
		    lVar2 = Core_Data_Effect_EffectData___ctor(param1[0xd],0);
		    local_4 = iVar4;
		    if (DAT_ram_00a56714 == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_5);
		      DAT_ram_00a56714 = '\x01';
		    }
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[6],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(lVar2 < 1),0);
		    if (iVar4 != 0) {
		      piVar3 = (int *)param1[6];
		      iVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      if (iVar4 == 0) {
		        iVar4 = StringLiteral_5;
		      }
		      iVar5 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		                (piVar3,iVar4,*(undefined4 *)(iVar5 + 0x2d4));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__HandleDataChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = Core_Extensions_Dict_EffectDictExt__GetAssetId(*(undefined4 *)(param2 + 8),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupIcon ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__SetupIcon
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = 0;
		  local_10 = 0;
		  func_ii_10814(*(undefined4 *)(*(int *)(param2 + 8) + 0x18),&local_10,0);
		  *(undefined8 *)(param1 + 0x24) = local_8;
		  *(undefined8 *)(param1 + 0x1c) = local_10;
		  iVar1 = **(int **)(param1 + 0x18);
		  local_18 = local_8;
		  local_20 = local_10;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x18),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/


		/* --- GHIDRA: SetupColor ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__SetupColor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  longlong lVar1;
		  uint param2_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  lVar1 = Core_Data_Effect_EffectData__get_CurrentDuration(param2,0);
		  if (lVar1 < 2) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(1 < *(int *)(param2 + 0x18));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupVisibleStackValue ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__SetupVisibleStackValue
		               (int param1,int param2,longlong param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a56714 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a56714 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(param3 < 1),0);
		  if (param2 != 0) {
		    piVar2 = *(int **)(param1 + 0x18);
		    iVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
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


		/* --- GHIDRA: SetTimeLeft ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffect__SetTimeLeft(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  float local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  iVar2 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		  local_10 = *(float *)(iVar2 + 0x14) * 1.5;
		  local_c = (float4)(*(float *)(iVar2 + 0xc) * 1.5);
		  local_8 = (float4)(*(float *)(iVar2 + 0x10) * 1.5);
		  local_18 = CONCAT44(local_8,local_c);
		  local_4 = (float4)local_10;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_18,0);
		  param1_00 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_20 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_28 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_28,0.4,0);
		  Utils_TimeUtils___cctor(param1_00,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: OnEnable ---
		int Gameplay_Combat_View_Players_LongEffects_LongEffect__OnEnable(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a56715 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_EffectData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12532);
		    DAT_ram_00a56715 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_EffectData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12532,Method_UI_ToolTip_ToolTipData_EffectData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x34);
		  return param1_00;
		}
		*/

}
