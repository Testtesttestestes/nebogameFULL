using System;
using System.Runtime.CompilerServices;
using Core.GameTime;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001177 RID: 4471
	[Token(Token = "0x2001177")]
	public class ServerTimeManager : IGameManager, IBaseManager
	{
		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x060069BF RID: 27071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A3")]
		public string Name
		{
			[Token(Token = "0x60069BF")]
			[Address(RVA = "0xB4DF", Offset = "0xB4DF", VA = "0xB4DF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400029A RID: 666
		// (add) Token: 0x060069C0 RID: 27072 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069C1 RID: 27073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069C0")]
			[Address(RVA = "0xB4E0", Offset = "0xB4E0", VA = "0xB4E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069C1")]
			[Address(RVA = "0xB4E1", Offset = "0xB4E1", VA = "0xB4E1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029B RID: 667
		// (add) Token: 0x060069C2 RID: 27074 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069C3 RID: 27075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069C2")]
			[Address(RVA = "0xB4E2", Offset = "0xB4E2", VA = "0xB4E2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069C3")]
			[Address(RVA = "0xB4E3", Offset = "0xB4E3", VA = "0xB4E3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A4")]
		public ICurrentTimeProvider CurrentTime
		{
			[Token(Token = "0x60069C4")]
			[Address(RVA = "0xB4E4", Offset = "0xB4E4", VA = "0xB4E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C5")]
		[Address(RVA = "0xB4E5", Offset = "0xB4E5", VA = "0xB4E5")]
		public ServerTimeManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ServerTimeManager___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xf4));
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C6")]
		[Address(RVA = "0xB4E6", Offset = "0xB4E6", VA = "0xB4E6", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ServerTimeManager__Deinit(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63832 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AbstractCurrentTimeProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ServerTimeManager_CurrentTimeProviderOnReadyEvent__);
		    DAT_ram_00a63832 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 0x10) + 0xd) == '\0') {
		    iVar1 = Core_GameTime_AbstractCurrentTimeProvider__Dispose(*(int *)(param1 + 0x10),0);
		    if (iVar1 == 0) {
		      uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar2 = unnamed_function_1417(uVar2);
		      uVar3 = unnamed_function_2232(&StringLiteral_6035);
		      System_String__Concat(uVar2,uVar3,0);
		      uVar3 = unnamed_function_2232(&Method_Core_Gameplay_Managers_ServerTimeManager_Init__);
		      func_ii_1050(uVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    uVar2 = unnamed_function_1417(System_Action_AbstractCurrentTimeProvider__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Core_Gameplay_Managers_ServerTimeManager_CurrentTimeProviderOnReadyEvent__,0);
		    Core_Materials_GrayscaleUI__Dispose(uVar3,uVar2,0);
		  }
		  else {
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C7")]
		[Address(RVA = "0xB4E7", Offset = "0xB4E7", VA = "0xB4E7", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ServerTimeManager__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63833 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AbstractCurrentTimeProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ServerTimeManager_CurrentTimeProviderOnReadyEvent__);
		    DAT_ram_00a63833 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_AbstractCurrentTimeProvider__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ServerTimeManager_CurrentTimeProviderOnReadyEvent__,0);
		  Core_GameTime_AbstractCurrentTimeProvider__add_ReadyEvent(param2,param1_00,0);
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C8")]
		[Address(RVA = "0xB4E8", Offset = "0xB4E8", VA = "0xB4E8")]
		private void CurrentTimeProviderOnReadyEvent(AbstractCurrentTimeProvider provider)
		{
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069C9")]
		[Address(RVA = "0xB4E9", Offset = "0xB4E9", VA = "0xB4E9")]
		private void Complete()
		{
		/* --- GHIDRA: Complete ---
		undefined4 Core_Gameplay_Managers_ServerTimeManager__Complete(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63834 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ShopManager_var);
		    DAT_ram_00a63834 = '\x01';
		  }
		  uVar2 = Core_Gameplay_Managers_ShopManager_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  piVar1 = (int *)func_ii_2734(uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xd8) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0xdc));
		  return uVar2;
		}
		*/

		}

		// Token: 0x04003815 RID: 14357
		[Token(Token = "0x4003815")]
		[FieldOffset(Offset = "0x10")]
		private ServerTimeProvider _provider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ServerTimeManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6382d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6382d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ServerTimeManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6382e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6382e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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
		void Core_Gameplay_Managers_ServerTimeManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6382f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6382f = '\x01';
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_ServerTimeManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63830 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63830 = '\x01';
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


		/* --- GHIDRA: get_CurrentTime ---
		void Core_Gameplay_Managers_ServerTimeManager__get_CurrentTime
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63831 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ServerTimeProvider_TypeInfo);
		    DAT_ram_00a63831 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x823070f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x823070f8:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x82307176;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0xc);
		code_r0x82307176:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar3 + 0x1c);
		  param1_01 = unnamed_function_1417(Core_GameTime_ServerTimeProvider_TypeInfo);
		  Core_GameTime_ServerTimeProvider__Dispose(param1_01,param2_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_01;
		  return;
		}
		*/

}
