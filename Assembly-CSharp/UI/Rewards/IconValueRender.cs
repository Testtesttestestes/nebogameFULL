using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class IconValueRender : AbstractRewardRender
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700017D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x5E61", Offset = "0x5E61", VA = "0x5E61")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5E62", Offset = "0x5E62", VA = "0x5E62")]
		public void SetValueVColor(Color32 color)
		{
		/* --- GHIDRA: SetValueVColor ---
		undefined4 UI_Rewards_IconValueRender__SetValueVColor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = AssetContent_GameImage___ctor(*(undefined4 *)(param1 + 0x28),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public string IconAssetId
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x5E63", Offset = "0x5E63", VA = "0x5E63")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x5E64", Offset = "0x5E64", VA = "0x5E64")]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public string Value
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x5E65", Offset = "0x5E65", VA = "0x5E65")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x5E66", Offset = "0x5E66", VA = "0x5E66")]
			set
			{
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x5E67", Offset = "0x5E67", VA = "0x5E67")]
		public void SetIcon(Sprite value)
		{
		/* --- GHIDRA: SetIcon ---
		void UI_Rewards_IconValueRender__SetIcon(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: SetIcon ---
		void UI_Rewards_IconValueRender__SetIcon(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x2c),*(undefined4 *)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x5E68", Offset = "0x5E68", VA = "0x5E68")]
		public void SetIcon(Texture value)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x5E69", Offset = "0x5E69", VA = "0x5E69", Slot = "10")]
		protected virtual void HandleValueChanged()
		{
		/* --- GHIDRA: HandleValueChanged ---
		void UI_Rewards_IconValueRender__HandleValueChanged(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59a06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a06 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  local_4 = func_ii_8038(param1_00,0);
		  local_8 = 0xffffffff;
		  local_c = Protocol_Consts_RewardTypes_TypeInfo;
		  param2_00 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  if (param2_00 == 0) {
		    param2_00 = StringLiteral_5;
		  }
		  UnityEngine_Texture2D___ctor(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x5E6A", Offset = "0x5E6A", VA = "0x5E6A", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		int * UI_Rewards_IconValueRender__HandleRewardChanged
		                (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59a07 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Rewards_RewardsContainer_Add_IconValueRender___);
		    DAT_ram_00a59a07 = '\x01';
		  }
		  iVar1 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)
		                      (*param2 + (uint)*(ushort *)
		                                        (Method_UI_Rewards_RewardsContainer_Add_IconValueRender___ +
		                                        0x2c) * 8 + 0xc4),
		                     Method_UI_Rewards_RewardsContainer_Add_IconValueRender___);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(iVar1 + 4) * 4))(param2,param1,iVar1);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		            (piVar2,param3,*(undefined4 *)(*piVar2 + 0xfc));
		  return piVar2;
		}
		*/

		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x5E6B", Offset = "0x5E6B", VA = "0x5E6B", Slot = "5")]
		public override AbstractRewardRender Render(RewardsContainer container, RewardData reward)
		{
		/* --- GHIDRA: Render ---
		void UI_Rewards_IconValueRender__Render(int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a08 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1509);
		    DAT_ram_00a59a08 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x30) = StringLiteral_1509;
		  local_30 = 0x3f8000003f800000;
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_24,&local_38,0);
		  *(undefined4 *)(param1 + 0x20) = (undefined4)local_24;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_14,&local_48,0);
		  *(undefined4 *)(param1 + 0x24) = local_14;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x5E6C", Offset = "0x5E6C", VA = "0x5E6C")]
		public IconValueRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_IconValueRender___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59a09 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59a09 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _valueTextField;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x30")]
		private string _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Icon ---
		void UI_Rewards_IconValueRender__get_Icon(int param1,uint *param2,undefined4 param3)
		
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
		  *(uint *)(param1 + 0x24) = uVar2;
		  local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		  iVar1 = **(int **)(param1 + 0x2c);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x2c),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void UI_Rewards_IconValueRender__get_Value(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(param1[0xc],param2,0);
		  if (iVar1 == 0) {
		    param1[0xc] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x114));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void UI_Rewards_IconValueRender__set_Value(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param2_00 = UnityEngine_UI_Image__get_activeSprite(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		            (*(undefined4 *)(param1 + 0x28),param2_00,0);
		  local_8 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  iVar1 = **(int **)(param1 + 0x28);
		  local_18 = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x28),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

}
