using System;
using Com.TheFallenGames.OSA.Core;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	public class PlayerViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CDD")]
		public ICombatPLayerView ItemRenderer
		{
			[Token(Token = "0x6004140")]
			[Address(RVA = "0x8FF7", Offset = "0x8FF7", VA = "0x8FF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDE")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6004141")]
			[Address(RVA = "0x8FF8", Offset = "0x8FF8", VA = "0x8FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004142")]
			[Address(RVA = "0x8FF9", Offset = "0x8FF9", VA = "0x8FF9")]
			set
			{
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x8FFA", Offset = "0x8FFA", VA = "0x8FFA", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x8FFB", Offset = "0x8FFB", VA = "0x8FFB", Slot = "11")]
		public override void OnBeforeDestroy()
		{
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x8FFC", Offset = "0x8FFC", VA = "0x8FFC")]
		public PlayerViewsHolder(IGameAudio gameAudio, Dictionaries dictionaries)
		{
		}

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x14")]
		private IGameAudio _gameAudio;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x18")]
		private Dictionaries _dictionaries;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x1C")]
		private ICombatPLayerView _itemRenderer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ItemRenderer ---
		undefined4
		Gameplay_Clans_Combat_View_Players_PlayerViewsHolder__get_ItemRenderer(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57782 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a57782 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x80dd82ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,8)
		  ;
		code_r0x80dd82ae:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_Player ---
		void Gameplay_Clans_Combat_View_Players_PlayerViewsHolder__get_Player
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57783 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a57783 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x108);
		        goto code_r0x80dd8355;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,9)
		  ;
		code_r0x80dd8355:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/


		/* --- GHIDRA: set_Player ---
		void Gameplay_Clans_Combat_View_Players_PlayerViewsHolder__set_Player(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57784 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ICombatPLayerView___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a57784 = '\x01';
		  }
		  piVar2 = (int *)func_ii_5677(*(undefined4 *)(param1 + 8),
		                               Method_UnityEngine_Component_GetComponent_ICombatPLayerView___);
		  *(int **)(param1 + 0x1c) = piVar2;
		  iVar6 = *piVar2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf8);
		        goto code_r0x80dd841b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,7);
		code_r0x80dd841b:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (iVar6 == 0) {
		    uVar1 = 0;
		    uVar4 = *(undefined4 *)(param1 + 0x18);
		    uVar5 = *(undefined4 *)(param1 + 0x14);
		    piVar2 = *(int **)(param1 + 0x1c);
		    iVar6 = *piVar2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dd84ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,0);
		code_r0x80dd84ab:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,0,uVar5,uVar4,puVar3[1]);
		  }
		  return;
		}
		*/

}
