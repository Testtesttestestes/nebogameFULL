using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001185 RID: 4485
	[Token(Token = "0x2001185")]
	public class TutorialUserManager : IGameManager, IBaseManager
	{
		// Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A94")]
		[Address(RVA = "0xB5AD", Offset = "0xB5AD", VA = "0xB5AD")]
		public TutorialUserManager(ITutorialManager tutorialManager)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638a2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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

		// Token: 0x140002B2 RID: 690
		// (add) Token: 0x06006A95 RID: 27285 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A96 RID: 27286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A95")]
			[Address(RVA = "0xB5AE", Offset = "0xB5AE", VA = "0xB5AE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A96")]
			[Address(RVA = "0xB5AF", Offset = "0xB5AF", VA = "0xB5AF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B3 RID: 691
		// (add) Token: 0x06006A97 RID: 27287 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A98 RID: 27288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A97")]
			[Address(RVA = "0xB5B0", Offset = "0xB5B0", VA = "0xB5B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A98")]
			[Address(RVA = "0xB5B1", Offset = "0xB5B1", VA = "0xB5B1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A99")]
		[Address(RVA = "0xB5B2", Offset = "0xB5B2", VA = "0xB5B2", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0xB5B3", Offset = "0xB5B3", VA = "0xB5B3", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Gameplay_Managers_Tutorial_TutorialUserManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a638a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16527);
		    DAT_ram_00a638a7 = '\x01';
		  }
		  return StringLiteral_16527;
		}
		*/

		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D2")]
		public string Name
		{
			[Token(Token = "0x6006A9B")]
			[Address(RVA = "0xB5B4", Offset = "0xB5B4", VA = "0xB5B4", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003856 RID: 14422
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x8")]
		private ITutorialManager _tutorialManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638a3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638a4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638a5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Tutorial_TutorialUserManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a638a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    DAT_ram_00a638a6 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x158);
		        goto code_r0x8230d3f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8230d3f2:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8230d479;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,
		                                5);
		code_r0x8230d479:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar4,puVar2[1]);
		  iVar3 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		undefined4
		Core_Gameplay_Managers_Tutorial_TutorialUserManager__get_Name(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a638a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8630);
		    DAT_ram_00a638a8 = '\x01';
		  }
		  return StringLiteral_8630;
		}
		*/

}
