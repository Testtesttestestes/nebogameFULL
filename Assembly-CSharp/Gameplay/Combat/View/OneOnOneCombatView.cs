using System;
using DG.Tweening;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Gameplay.Combat.View.Tweens;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x0200091F RID: 2335
	[Token(Token = "0x200091F")]
	public class OneOnOneCombatView : AbstractCombatView
	{
		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADB")]
		public ICombatPLayerView LeftPlayerView
		{
			[Token(Token = "0x6003705")]
			[Address(RVA = "0x86F4", Offset = "0x86F4", VA = "0x86F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADC")]
		public ICombatPLayerView RightPlayerView
		{
			[Token(Token = "0x6003706")]
			[Address(RVA = "0x86F5", Offset = "0x86F5", VA = "0x86F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADD")]
		public SkillsInfoVisibilityHandler SkillsInfoVisibilityHandler
		{
			[Token(Token = "0x6003707")]
			[Address(RVA = "0x86F6", Offset = "0x86F6", VA = "0x86F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADE")]
		public StartCombatBuilder StartupUITweenBuilder
		{
			[Token(Token = "0x6003708")]
			[Address(RVA = "0x86F7", Offset = "0x86F7", VA = "0x86F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000ADF")]
		public PlayerChatBubble LeftPlayerChat
		{
			[Token(Token = "0x6003709")]
			[Address(RVA = "0x86F8", Offset = "0x86F8", VA = "0x86F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE0")]
		public PlayerChatBubble RightPlayerChat
		{
			[Token(Token = "0x600370A")]
			[Address(RVA = "0x86F9", Offset = "0x86F9", VA = "0x86F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE1")]
		public ICombatSpellDisplay ElixirDisplay
		{
			[Token(Token = "0x600370B")]
			[Address(RVA = "0x86FA", Offset = "0x86FA", VA = "0x86FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x86FB", Offset = "0x86FB", VA = "0x86FB")]
		public CombatSpellButton AddElixir(CombatSpellData spell)
		{
		/* --- GHIDRA: AddElixir ---
		undefined4
		Gameplay_Combat_View_OneOnOneCombatView__AddElixir(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63b35 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a63b35 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x50);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x82341638;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,8);
		code_r0x82341638:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == param2) {
		    return *(undefined4 *)(param1 + 0x50);
		  }
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x54);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x823416c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,8);
		code_r0x823416c7:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == param2) {
		    return *(undefined4 *)(param1 + 0x54);
		  }
		  Gameplay_Combat_View_AbstractCombatView__GetSpell(puVar2,param2,puVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x86FC", Offset = "0x86FC", VA = "0x86FC", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayer ---
		void Gameplay_Combat_View_OneOnOneCombatView__GetPlayer
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param2 + iVar1 * 4 + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x86FD", Offset = "0x86FD", VA = "0x86FD", Slot = "12")]
		protected virtual void HandleHideInstantElements(GameObject[] elements)
		{
		/* --- GHIDRA: HandleHideInstantElements ---
		void Gameplay_Combat_View_OneOnOneCombatView__HandleHideInstantElements
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a63b36 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63b36 = '\x01';
		  }
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(param2 + iVar1 * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(param1_00,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x86FE", Offset = "0x86FE", VA = "0x86FE", Slot = "13")]
		protected virtual void HandleDestroyInstantElements(GameObject[] elements)
		{
		/* --- GHIDRA: HandleDestroyInstantElements ---
		undefined4
		Gameplay_Combat_View_OneOnOneCombatView__HandleDestroyInstantElements
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63b37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a63b37 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x28);
		  iVar4 = param3[2];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x120) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0x124));
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x10) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = param2;
		  *(int *)(iVar2 + 0xc) = iVar4;
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))(piVar3,iVar2,*(undefined4 *)(iVar4 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x86FF", Offset = "0x86FF", VA = "0x86FF", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		void Gameplay_Combat_View_OneOnOneCombatView__ShowGameOverView
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63b38 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_OneOnOneCombatView___c__DisplayClass33_0__ShowGameOver_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_OneOnOneCombatView___c__DisplayClass33_0_TypeInfo);
		    DAT_ram_00a63b38 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_OneOnOneCombatView___c__DisplayClass33_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x14) = param4;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(int *)(param2_00 + 8) = param1;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x6c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = DG_Tweening_DOTweenModuleSprite__DOColor(*(undefined4 *)(param1 + 0x6c),0.7,0.7,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,0x1a,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		                    );
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x6c),0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		                    );
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param2_00,
		             Method_Gameplay_Combat_View_OneOnOneCombatView___c__DisplayClass33_0__ShowGameOver_b__0__
		             ,0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,uVar2,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x8700", Offset = "0x8700", VA = "0x8700", Slot = "11")]
		public override void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		/* --- GHIDRA: ShowGameOver ---
		void Gameplay_Combat_View_OneOnOneCombatView__ShowGameOver
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a63b39 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a63b39 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x823419aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,4);
		code_r0x823419aa:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,0x3f800000,0x3f99999a,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x8701", Offset = "0x8701", VA = "0x8701", Slot = "14")]
		protected virtual void ShowOpponentDeath(ICombatPLayerView player)
		{
		/* --- GHIDRA: ShowOpponentDeath ---
		void Gameplay_Combat_View_OneOnOneCombatView__ShowOpponentDeath(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63b3a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject___TypeInfo);
		    DAT_ram_00a63b3a = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_GameObject___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  if (DAT_ram_00a63b1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TypeInfo);
		    DAT_ram_00a63b1c = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_CombatSpellData__CombatSpellButton___ctor__
		            );
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x8702", Offset = "0x8702", VA = "0x8702")]
		public OneOnOneCombatView()
		{
		}

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject[] _hideInstantElements;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _destroyInstantElements;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject LeftPodium;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject RightPodium;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OneOnOneCombatView.LeftRightPlayerPostionX[] PlayerPodiumPodiumGameOverPositionX;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CombatPlayerView leftPlayerView;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CombatPlayerView rightPlayerView;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkillsInfoVisibilityHandler _skillsInfoVisibilityHandler;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected AbstractCombatSpellsDisplay _elixirs;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StartCombatBuilder _startCombatBuilder;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private PlayerChatBubble _leftPlayerChat;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PlayerChatBubble _rightPlayerChat;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x6C")]
		public SpriteRenderer BackShadeSprite;

		// Token: 0x02000920 RID: 2336
		[Token(Token = "0x2000920")]
		[Serializable]
		public class LeftRightPlayerPostionX
		{
			// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003714")]
			[Address(RVA = "0x8703", Offset = "0x8703", VA = "0x8703")]
			public LeftRightPlayerPostionX()
			{
			}

			// Token: 0x04001E34 RID: 7732
			[Token(Token = "0x4001E34")]
			[FieldOffset(Offset = "0x8")]
			public float LeftX;

			// Token: 0x04001E35 RID: 7733
			[Token(Token = "0x4001E35")]
			[FieldOffset(Offset = "0xC")]
			public float RightX;

			// Token: 0x04001E36 RID: 7734
			[Token(Token = "0x4001E36")]
			[FieldOffset(Offset = "0x10")]
			public float Duration;

			// Token: 0x04001E37 RID: 7735
			[Token(Token = "0x4001E37")]
			[FieldOffset(Offset = "0x14")]
			public Ease Ease;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ElixirDisplay ---
		undefined4
		Gameplay_Combat_View_OneOnOneCombatView__get_ElixirDisplay
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Combat_View_AbstractCombatView__AddSpell
		                    (param1,param2,*(undefined4 *)(param1 + 0x5c),param1);
		  return uVar1;
		}
		*/

}
