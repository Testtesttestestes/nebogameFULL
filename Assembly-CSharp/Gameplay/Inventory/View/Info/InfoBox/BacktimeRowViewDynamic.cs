using System;
using System.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class BacktimeRowViewDynamic : TitleRowView
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000798")]
		public BackTime Backtime
		{
			[Token(Token = "0x6002815")]
			[Address(RVA = "0x793A", Offset = "0x793A", VA = "0x793A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002816")]
			[Address(RVA = "0x793B", Offset = "0x793B", VA = "0x793B")]
			set
			{
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x793C", Offset = "0x793C", VA = "0x793C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x3c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x3c),0);
		  }
		  if (DAT_ram_00a5a0d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		              );
		    DAT_ram_00a5a0d3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(int *)(param1_00 + 0x10) = param1;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x793D", Offset = "0x793D", VA = "0x793D")]
		private void HandleBacktimeChanged()
		{
		/* --- GHIDRA: HandleBacktimeChanged ---
		int Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__HandleBacktimeChanged
		              (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5a0d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		              );
		    DAT_ram_00a5a0d3 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x793E", Offset = "0x793E", VA = "0x793E")]
		private IEnumerator DisplayBacktimeCoroutine()
		{
		/* --- GHIDRA: DisplayBacktimeCoroutine ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  float fVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int *piVar4;
		  uint uVar5;
		  double param1_00;
		  int iVar6;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5a0d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15062);
		    DAT_ram_00a5a0d4 = '\x01';
		  }
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x38),0);
		  piVar3 = *(int **)(param1 + 0x24);
		  if (fVar1 == 0.0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15062,1,0,1,0,0,0,0);
		  }
		  else {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param1_00 = (double)fVar1;
		    uVar2 = Utils_TimeUtils__DateFormat(param1_00,0);
		    in_register_20000004 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  }
		  iVar6 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (CONCAT44(in_register_20000004,piVar3),uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0x20);
		  if (piVar3 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar3 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_BackTimeRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar3 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_BackTimeRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_BackTimeRow_TypeInfo)) {
		      System_Activator__CreateInstance(piVar3,Core_Data_InfoRows_BackTimeRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  if (fVar1 <= (float)piVar3[5]) {
		    uVar5 = *(uint *)(param1 + 0x28);
		    local_8 = (float4)((float)(uVar5 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar5 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar5 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar5 >> 8 & 0xff) / 255.0);
		    local_18 = CONCAT44(local_4,local_8);
		    local_20 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x178) * 4))
		              (piVar4,&local_20,*(undefined4 *)(*piVar4 + 0x17c));
		    uVar5 = *(uint *)(param1 + 0x30);
		    local_8 = (float4)((float)(uVar5 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar5 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar5 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar5 >> 8 & 0xff) / 255.0);
		    iVar6 = **(int **)(param1 + 0x24);
		    local_28 = CONCAT44(local_4,local_8);
		    local_30 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x178) * 4))
		              (*(int **)(param1 + 0x24),&local_30,*(undefined4 *)(iVar6 + 0x17c));
		  }
		  else {
		    uVar5 = *(uint *)(param1 + 0x2c);
		    local_8 = (float4)((float)(uVar5 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar5 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar5 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar5 >> 8 & 0xff) / 255.0);
		    local_38 = CONCAT44(local_4,local_8);
		    local_40 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x178) * 4))
		              (piVar4,&local_40,*(undefined4 *)(*piVar4 + 0x17c));
		    uVar5 = *(uint *)(param1 + 0x34);
		    local_8 = (float4)((float)(uVar5 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar5 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar5 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar5 >> 8 & 0xff) / 255.0);
		    iVar6 = **(int **)(param1 + 0x24);
		    local_48 = CONCAT44(local_4,local_8);
		    local_50 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x178) * 4))
		              (*(int **)(param1 + 0x24),&local_50,*(undefined4 *)(iVar6 + 0x17c));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x793F", Offset = "0x793F", VA = "0x793F")]
		private void DisplayTime()
		{
		/* --- GHIDRA: DisplayTime ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayTime
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  int param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a0d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    DAT_ram_00a5a0d5 = '\x01';
		  }
		  Gameplay_Inventory_View_Info_InfoBox_TitleRowView__get_Data(param1,0);
		  param1_01 = *(int **)(param1 + 0x20);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_BackTimeRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_BackTimeRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_BackTimeRow_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Core_Data_InfoRows_BackTimeRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x10),0);
		    uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_01[3],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,uVar2 ^ 1,0);
		    if (param1_01[4] != *(int *)(param1 + 0x38)) {
		      *(int *)(param1 + 0x38) = param1_01[4];
		      if (*(int *)(param1 + 0x3c) != 0) {
		        func_ii_7950(*(int *)(param1 + 0x3c),0);
		      }
		      if (DAT_ram_00a5a0d3 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                  );
		        DAT_ram_00a5a0d3 = '\x01';
		      }
		      param1_00 = unnamed_function_1417
		                            (
		                            Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                            );
		      Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		      *(int *)(param1_00 + 0x10) = param1;
		      uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		      *(undefined4 *)(param1 + 0x3c) = uVar1;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x7940", Offset = "0x7940", VA = "0x7940", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  local_c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_48,0);
		  *(undefined4 *)(param1 + 0x28) = local_4;
		  local_1c = 0x3f8000003f800000;
		  local_50 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_58 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_58,0);
		  *(undefined4 *)(param1 + 0x2c) = local_4;
		  local_2c = 0x3f8000003f800000;
		  local_60 = 0x3f8000003f800000;
		  local_34 = 0x3f8000003f800000;
		  local_68 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_68,0);
		  *(undefined4 *)(param1 + 0x34) = local_4;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x7941", Offset = "0x7941", VA = "0x7941")]
		public BacktimeRowViewDynamic()
		{
		}

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timeField;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _warnTitleColor;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color32 _idleTitleColor;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color32 _idleColor;

		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		[FieldOffset(Offset = "0x38")]
		protected BackTime _backtime;

		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		[FieldOffset(Offset = "0x3C")]
		private Coroutine _routine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Backtime ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__get_Backtime
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (param2 != *(int *)(param1 + 0x38)) {
		    *(int *)(param1 + 0x38) = param2;
		    if (*(int *)(param1 + 0x3c) != 0) {
		      func_ii_7950(*(int *)(param1 + 0x3c),0);
		    }
		    if (DAT_ram_00a5a0d3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                );
		      DAT_ram_00a5a0d3 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__DisplayBacktimeCoroutine_d__12_TypeInfo
		                          );
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		    *(int *)(param1_00 + 0x10) = param1;
		    uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x3c) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Backtime ---
		void Gameplay_Inventory_View_Info_InfoBox_BacktimeRowViewDynamic__set_Backtime
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x3c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x3c),0);
		  }
		  return;
		}
		*/

}
