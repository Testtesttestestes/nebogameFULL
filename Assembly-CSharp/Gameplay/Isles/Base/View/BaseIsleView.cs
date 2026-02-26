using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using CloudsFly;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x2000CFB")]
	public class BaseIsleView : BaseWorldObjectRenderer
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001069")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x6005107")]
			[Address(RVA = "0x9EF8", Offset = "0x9EF8", VA = "0x9EF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106A")]
		public GameSpriteRendererLoaderInteractable BgSprite
		{
			[Token(Token = "0x6005108")]
			[Address(RVA = "0x9EF9", Offset = "0x9EF9", VA = "0x9EF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EA RID: 490
		// (add) Token: 0x06005109 RID: 20745 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600510A RID: 20746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EA")]
		public event Action OnClickEvent
		{
			[Token(Token = "0x6005109")]
			[Address(RVA = "0x9EFA", Offset = "0x9EFA", VA = "0x9EFA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600510A")]
			[Address(RVA = "0x9EFB", Offset = "0x9EFB", VA = "0x9EFB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x9EFC", Offset = "0x9EFC", VA = "0x9EFC")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Isles_Base_View_BaseIsleView__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58ce2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_Base_View_BaseIsleView_OnPointerClick__);
		    DAT_ram_00a58ce2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Isles_Base_View_BaseIsleView_OnPointerClick__,0);
		  AssetContent_Loaders_GameSpriteRendererLoaderInteractable__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510C")]
		[Address(RVA = "0x9EFD", Offset = "0x9EFD", VA = "0x9EFD")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510D")]
		[Address(RVA = "0x9EFE", Offset = "0x9EFE", VA = "0x9EFE")]
		private void OnPointerClick()
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Isles_Base_View_BaseIsleView__OnPointerClick(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = func_ii_7674(*(undefined4 *)(param1 + 0x28),0);
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		            (param1_00,*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x9EFF", Offset = "0x9EFF", VA = "0x9EFF", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_Base_View_BaseIsleView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = func_ii_7674(*(undefined4 *)(param1 + 0x28),0);
		  func_ii_7677(param1_00,*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x9F00", Offset = "0x9F00", VA = "0x9F00", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106B")]
		public Dictionary<uint, BaseIsleBuildingView> BuildingViews
		{
			[Token(Token = "0x6005110")]
			[Address(RVA = "0x3029", Offset = "0x3029", VA = "0x3029")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005111")]
		[Address(RVA = "0x9F01", Offset = "0x9F01", VA = "0x9F01")]
		public BaseIsleView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Base_View_BaseIsleView___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a58ce4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentBossInstanceChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentCreateRequestChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_IsCurrentChangedEvent__);
		    DAT_ram_00a58ce4 = '\x01';
		  }
		  *(int *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  uVar6 = *(undefined4 *)(param3 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Isles_Base_View_IsleBossContainer_IsCurrentChangedEvent__,
		             0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param3 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(param3 + 0x18) = piVar3, *piVar3 != iVar7)) {
		    System_Activator__CreateInstance(piVar3,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1e0);
		        goto code_r0x80f9ae50;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80f9ae50:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  iVar8 = *(int *)(iVar7 + 0x14);
		  uVar6 = *(undefined4 *)(iVar8 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentBossInstanceChangedEvent__,0);
		  iVar7 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  uVar2 = System_Action_long__TypeInfo;
		  if (iVar7 == 0) {
		    *(undefined4 *)(iVar8 + 0x18) = 0;
		  }
		  else {
		    iVar5 = func_ii_1082(iVar7,System_Action_long__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar8 + 0x18) = iVar5;
		    uVar2 = System_Action_long__TypeInfo;
		    iVar8 = func_ii_1082(iVar7,System_Action_long__TypeInfo);
		    if (iVar8 == 0) {
		      System_Activator__CreateInstance(iVar7,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1e0);
		        goto code_r0x80f9af6a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80f9af6a:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  iVar8 = *(int *)(iVar7 + 0x14);
		  uVar6 = *(undefined4 *)(iVar8 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentCreateRequestChangedEvent__,0)
		  ;
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x1c) = 0;
		    Gameplay_Isles_Base_View_IsleBossContainer__IsCurrentChangedEvent(param1,0);
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar8 + 0x1c) = piVar3, *piVar3 == iVar7)) {
		    Gameplay_Isles_Base_View_IsleBossContainer__IsCurrentChangedEvent(param1,piVar3);
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002C24 RID: 11300
		[Token(Token = "0x4002C24")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BaseIsleBuildingView[] _buildings;

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<uint, BaseIsleBuildingView> _buildingViews;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BgSprite ---
		void Gameplay_Isles_Base_View_BaseIsleView__get_BgSprite
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58cdf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58cdf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnClickEvent ---
		void Gameplay_Isles_Base_View_BaseIsleView__add_OnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58ce0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58ce0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnClickEvent ---
		void Gameplay_Isles_Base_View_BaseIsleView__remove_OnClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58ce1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_Base_View_BaseIsleView_OnPointerClick__);
		    DAT_ram_00a58ce1 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Isles_Base_View_BaseIsleView_OnPointerClick__,0);
		  AssetContent_Loaders_GameSpriteRendererLoader___ctor(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_BuildingViews ---
		int * Gameplay_Isles_Base_View_BaseIsleView__get_BuildingViews(int *param1)
		
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

}
