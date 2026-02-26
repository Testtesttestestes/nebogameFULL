using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public abstract class AbstractRewardRender : MonoBehaviour, IDisposable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000177")]
		public AbstractRewardRender RewardRender
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x5E47", Offset = "0x5E47", VA = "0x5E47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x5E48", Offset = "0x5E48", VA = "0x5E48", Slot = "5")]
		public virtual AbstractRewardRender Render(RewardsContainer container, RewardData reward)
		{
		/* --- GHIDRA: Render ---
		void UI_Rewards_AbstractRewardRender__Render(undefined4 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined4 *)(param2 + 0x20);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		public Color32 LabelColor
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x5E49", Offset = "0x5E49", VA = "0x5E49")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x5E4A", Offset = "0x5E4A", VA = "0x5E4A")]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public Color32 ValueColor
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x5E4B", Offset = "0x5E4B", VA = "0x5E4B")]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x5E4C", Offset = "0x5E4C", VA = "0x5E4C")]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public virtual RewardData Reward
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x5E4D", Offset = "0x5E4D", VA = "0x5E4D", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x5E4E", Offset = "0x5E4E", VA = "0x5E4E", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x5E4F", Offset = "0x5E4F", VA = "0x5E4F", Slot = "8")]
		protected virtual void HandleRewardChanged()
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x5E50", Offset = "0x5E50", VA = "0x5E50", Slot = "9")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Rewards_AbstractRewardRender__Dispose(int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))(param1,*(undefined4 *)(*param1 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x5E51", Offset = "0x5E51", VA = "0x5E51")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Rewards_AbstractRewardRender__OnDestroy(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  uint uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a59a01 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a01 = '\x01';
		  }
		  param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IconValueRender___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    uVar2 = *(uint *)(param1 + 0x24);
		    *(uint *)(param1_00 + 0x24) = uVar2;
		    local_8 = (float4)((float)(uVar2 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar2 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar2 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar2 >> 8 & 0xff) / 255.0);
		    iVar1 = **(int **)(param1_00 + 0x2c);
		    local_18 = CONCAT44(local_4,local_8);
		    local_20 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1_00 + 0x2c),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x5E52", Offset = "0x5E52", VA = "0x5E52")]
		protected void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Rewards_AbstractRewardRender__Start(int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  local_c = 0x3f8000003f800000;
		  local_30 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_38,0);
		  *(undefined4 *)(param1 + 0x20) = local_4;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_48,0);
		  *(undefined4 *)(param1 + 0x24) = local_4;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5E53", Offset = "0x5E53", VA = "0x5E53")]
		protected AbstractRewardRender()
		{
		}

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		protected RewardsContainer _container;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public AbstractRewardRender _rewardRender;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public RewardsRender RootRewardsRender;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x1C")]
		protected RewardData _reward;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x20")]
		private Color32 _labelColor;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x24")]
		private Color32 _valueColor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardRender ---
		undefined4
		UI_Rewards_AbstractRewardRender__get_RewardRender
		          (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  param1[4] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,param3,*(undefined4 *)(*param1 + 0xfc));
		  return 0;
		}
		*/


		/* --- GHIDRA: get_LabelColor ---
		void UI_Rewards_AbstractRewardRender__get_LabelColor
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x20) = *param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_Reward ---
		void UI_Rewards_AbstractRewardRender__get_Reward(int *param1,int param2,undefined4 param3)
		
		{
		  param1[7] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/

}
