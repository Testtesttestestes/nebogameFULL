using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000674 RID: 1652
	[Token(Token = "0x2000674")]
	public class BackTimeRowView : TitleRowView
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000797")]
		public BackTime Backtime
		{
			[Token(Token = "0x600280F")]
			[Address(RVA = "0x7934", Offset = "0x7934", VA = "0x7934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002810")]
			[Address(RVA = "0x7935", Offset = "0x7935", VA = "0x7935")]
			set
			{
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x7936", Offset = "0x7936", VA = "0x7936")]
		private void HandleBacktimeChanged()
		{
		/* --- GHIDRA: HandleBacktimeChanged ---
		void Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__HandleBacktimeChanged
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
		  
		  if (DAT_ram_00a5a0d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15062);
		    DAT_ram_00a5a0d1 = '\x01';
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

		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x7937", Offset = "0x7937", VA = "0x7937")]
		private void DisplayTime()
		{
		/* --- GHIDRA: DisplayTime ---
		void Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__DisplayTime(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a0d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    DAT_ram_00a5a0d2 = '\x01';
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
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x10),0);
		    uVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_01[3],0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,uVar1 ^ 1,0);
		    if (param1_01[4] != *(int *)(param1 + 0x38)) {
		      *(int *)(param1 + 0x38) = param1_01[4];
		      Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__HandleBacktimeChanged(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x7938", Offset = "0x7938", VA = "0x7938", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x7939", Offset = "0x7939", VA = "0x7939")]
		public BackTimeRowView()
		{
		}

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timeField;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color32 _warnTitleColor;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color32 _idleTitleColor;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color32 _warnColor;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color32 _idleColor;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x38")]
		protected BackTime _backtime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Backtime ---
		void Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__get_Backtime
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x38)) {
		    *(int *)(param1 + 0x38) = param2;
		    Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__HandleBacktimeChanged(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Backtime ---
		void Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__set_Backtime
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_InfoBox_BackTimeRowView__HandleBacktimeChanged(param1,param1);
		  return;
		}
		*/

}
