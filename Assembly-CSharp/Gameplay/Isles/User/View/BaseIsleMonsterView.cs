using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D0F RID: 3343
	[Token(Token = "0x2000D0F")]
	public class BaseIsleMonsterView : BaseWorldObjectRenderer, IDisposable
	{
		// Token: 0x140001EF RID: 495
		// (add) Token: 0x06005190 RID: 20880 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005191 RID: 20881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EF")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6005190")]
			[Address(RVA = "0x9F6C", Offset = "0x9F6C", VA = "0x9F6C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005191")]
			[Address(RVA = "0x9F6D", Offset = "0x9F6D", VA = "0x9F6D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001084 RID: 4228
		// (set) Token: 0x06005192 RID: 20882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001084")]
		public string AssetId
		{
			[Token(Token = "0x6005192")]
			[Address(RVA = "0x9F6E", Offset = "0x9F6E", VA = "0x9F6E")]
			set
			{
			}
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005193")]
		[Address(RVA = "0x9F6F", Offset = "0x9F6F", VA = "0x9F6F")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x9F70", Offset = "0x9F70", VA = "0x9F70")]
		private void GameAssetViewOnClickedEvent(GameAssetViewSpriteRenderer obj)
		{
		/* --- GHIDRA: GameAssetViewOnClickedEvent ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__GameAssetViewOnClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005195")]
		[Address(RVA = "0x9F71", Offset = "0x9F71", VA = "0x9F71", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  func_ii_7665(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005196")]
		[Address(RVA = "0x9F72", Offset = "0x9F72", VA = "0x9F72", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__ApplySortingLayerId(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x28) = 0;
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(param1 + 0x24),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06005197 RID: 20887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x9F73", Offset = "0x9F73", VA = "0x9F73", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d20 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_BaseIsleMonsterView_GameAssetViewOnClickedEvent__);
		    DAT_ram_00a58d20 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Isles_User_View_BaseIsleMonsterView_GameAssetViewOnClickedEvent__,0);
		  AssetContent_GameAssetViewSpriteRenderer__add_ClickedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005198")]
		[Address(RVA = "0x9F74", Offset = "0x9F74", VA = "0x9F74", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x9F75", Offset = "0x9F75", VA = "0x9F75")]
		public BaseIsleMonsterView()
		{
		}

		// Token: 0x04002C5B RID: 11355
		[Token(Token = "0x4002C5B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewSpriteRenderer _gameAssetView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d1e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d1e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(param1 + 0x24),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_AssetId ---
		void Gameplay_Isles_User_View_BaseIsleMonsterView__set_AssetId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d1f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_BaseIsleMonsterView_GameAssetViewOnClickedEvent__);
		    DAT_ram_00a58d1f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Isles_User_View_BaseIsleMonsterView_GameAssetViewOnClickedEvent__,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_SpriteRenderer(param1_01,param1_00,0);
		  return;
		}
		*/

}
