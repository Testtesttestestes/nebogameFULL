using System;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200067C RID: 1660
	[Token(Token = "0x200067C")]
	public class TitleRowView : MonoBehaviour
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079D")]
		public int Index
		{
			[Token(Token = "0x6002833")]
			[Address(RVA = "0x7955", Offset = "0x7955", VA = "0x7955")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002834")]
			[Address(RVA = "0x1F7D", Offset = "0x1F7D", VA = "0x1F7D")]
			set
			{
			}
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x7956", Offset = "0x7956", VA = "0x7956", Slot = "4")]
		protected virtual void HandleIndexChanged()
		{
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002837 RID: 10295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079E")]
		public IInformationRow Data
		{
			[Token(Token = "0x6002836")]
			[Address(RVA = "0x7957", Offset = "0x7957", VA = "0x7957")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002837")]
			[Address(RVA = "0x1F84", Offset = "0x1F84", VA = "0x1F84")]
			set
			{
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x7958", Offset = "0x7958", VA = "0x7958", Slot = "5")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x7959", Offset = "0x7959", VA = "0x7959", Slot = "6")]
		public virtual void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__SetTitle
		               (int param1,uint *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar2 = *param2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x10);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x10),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x795A", Offset = "0x795A", VA = "0x795A", Slot = "7")]
		public virtual void SetTitleColor(in Color32 color)
		{
		/* --- GHIDRA: SetTitleColor ---
		undefined4
		Gameplay_Inventory_View_Info_InfoBox_TitleRowView__SetTitleColor(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x1e4);
		}
		*/

		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x00007A58 File Offset: 0x00005C58
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079F")]
		public virtual HorizontalAlignmentOptions HorizontalAlignmentTitleText
		{
			[Token(Token = "0x600283B")]
			[Address(RVA = "0x795B", Offset = "0x795B", VA = "0x795B", Slot = "8")]
			get
			{
				return (HorizontalAlignmentOptions)0;
			}
			[Token(Token = "0x600283C")]
			[Address(RVA = "0x795C", Offset = "0x795C", VA = "0x795C", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00007A70 File Offset: 0x00005C70
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A0")]
		public virtual VerticalAlignmentOptions VerticalAlignmentTitleText
		{
			[Token(Token = "0x600283D")]
			[Address(RVA = "0x795D", Offset = "0x795D", VA = "0x795D", Slot = "10")]
			get
			{
				return (VerticalAlignmentOptions)0;
			}
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x795E", Offset = "0x795E", VA = "0x795E", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		public virtual TextAnchor ContainerAlign
		{
			[Token(Token = "0x600283F")]
			[Address(RVA = "0x795F", Offset = "0x795F", VA = "0x795F", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x7960", Offset = "0x7960", VA = "0x7960")]
		public TitleRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo);
		    DAT_ram_00a5a0de = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    param2_00 = System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)
		                          (Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu_TypeInfo + 0x5c),
		                         iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _titleField;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_lightBgSprite")]
		[SerializeField]
		private Sprite _evenBgSprite;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x1C")]
		protected int _index;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x20")]
		protected IInformationRow _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Index ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__get_Index(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (((*(byte *)(param1 + 0x1c) & 1) != 0) &&
		     (iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                        (*(undefined4 *)(param1 + 0x14),0), iVar1 != 0)) {
		    func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x18),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Index ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__set_Index
		               (int param1,uint *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar2 = *param2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x28);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x28),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__get_Data(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a0dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a5a0dd = '\x01';
		  }
		  param1_00 = (int *)param1[8];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x811c77ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x811c77ce:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,uVar3,*(undefined4 *)(*param1 + 0xf4));
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		int * Gameplay_Inventory_View_Info_InfoBox_TitleRowView__set_Data(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_HorizontalAlignmentTitleText ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__get_HorizontalAlignmentTitleText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_Text__get_horizontalAlignment(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_HorizontalAlignmentTitleText ---
		undefined4
		Gameplay_Inventory_View_Info_InfoBox_TitleRowView__set_HorizontalAlignmentTitleText
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x1e8);
		}
		*/


		/* --- GHIDRA: get_VerticalAlignmentTitleText ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleRowView__get_VerticalAlignmentTitleText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_Text__get_verticalAlignment(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

}
