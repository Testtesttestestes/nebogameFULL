using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Application.Managers
{
	// Token: 0x02001252 RID: 4690
	[Token(Token = "0x2001252")]
	public class NotificationManager : INotificationManager, IAppManager, IBaseManager, IDisposable
	{
		// Token: 0x140002ED RID: 749
		// (add) Token: 0x06006F2E RID: 28462 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F2F RID: 28463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002ED")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F2E")]
			[Address(RVA = "0xB9A9", Offset = "0xB9A9", VA = "0xB9A9", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F2F")]
			[Address(RVA = "0xB9AA", Offset = "0xB9AA", VA = "0xB9AA", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EE RID: 750
		// (add) Token: 0x06006F30 RID: 28464 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F31 RID: 28465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F30")]
			[Address(RVA = "0xB9AB", Offset = "0xB9AB", VA = "0xB9AB", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F31")]
			[Address(RVA = "0xB9AC", Offset = "0xB9AC", VA = "0xB9AC", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F32")]
		[Address(RVA = "0xB9AD", Offset = "0xB9AD", VA = "0xB9AD")]
		public NotificationManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_NotificationManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a836 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    DAT_ram_00a5a836 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8127c2ab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,4);
		code_r0x8127c2ab:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F33")]
		[Address(RVA = "0xB9AE", Offset = "0xB9AE", VA = "0xB9AE", Slot = "11")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_NotificationManager__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F34")]
		[Address(RVA = "0xB9AF", Offset = "0xB9AF", VA = "0xB9AF")]
		private void ImplementationOnInitCompleteEvent(IBaseManager manager)
		{
		/* --- GHIDRA: ImplementationOnInitCompleteEvent ---
		void Core_Application_Managers_NotificationManager__ImplementationOnInitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  Core_Application_Managers_NotificationManager__get_Name(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F35")]
		[Address(RVA = "0xB9B0", Offset = "0xB9B0", VA = "0xB9B0")]
		private void ImplementationOnDeinitCompleteEvent(IBaseManager manager)
		{
		/* --- GHIDRA: ImplementationOnDeinitCompleteEvent ---
		void Core_Application_Managers_NotificationManager__ImplementationOnDeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a837 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    DAT_ram_00a5a837 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8127c523;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,5);
		code_r0x8127c523:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F36")]
		[Address(RVA = "0xB9B1", Offset = "0xB9B1", VA = "0xB9B1", Slot = "12")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Application_Managers_NotificationManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a838 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11658);
		    DAT_ram_00a5a838 = '\x01';
		  }
		  return StringLiteral_11658;
		}
		*/

		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B4")]
		public string Name
		{
			[Token(Token = "0x6006F37")]
			[Address(RVA = "0xB9B2", Offset = "0xB9B2", VA = "0xB9B2", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F38")]
		[Address(RVA = "0xB9B3", Offset = "0xB9B3", VA = "0xB9B3", Slot = "14")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Application_Managers_NotificationManager__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a83a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    DAT_ram_00a5a83a = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8127c5f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_Managers_INotificationManager_TypeInfo,0)
		  ;
		code_r0x8127c5f3:
		  (**(code **)((ulonglong)*puVar2 * 4))
		            (param1_00,param2,param3,param4,param5,param6,param7,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F39")]
		[Address(RVA = "0xB9B4", Offset = "0xB9B4", VA = "0xB9B4", Slot = "4")]
		public void ScheduleNotification(int id, string title, string message, int delay, Dictionary<string, object> developerPayload, LocalNotifications channel)
		{
		/* --- GHIDRA: ScheduleNotification ---
		void Core_Application_Managers_NotificationManager__ScheduleNotification
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a83b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    DAT_ram_00a5a83b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x8127c6a6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_Managers_INotificationManager_TypeInfo,1)
		  ;
		code_r0x8127c6a6:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0xB9B5", Offset = "0xB9B5", VA = "0xB9B5", Slot = "5")]
		public void ClearNotification(int id)
		{
		/* --- GHIDRA: ClearNotification ---
		void Core_Application_Managers_NotificationManager__ClearNotification
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a83c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    DAT_ram_00a5a83c = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x8127c74f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_Managers_INotificationManager_TypeInfo,2)
		  ;
		code_r0x8127c74f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0xB9B6", Offset = "0xB9B6", VA = "0xB9B6", Slot = "6")]
		public void InitChannels(IDictProvider dictProvider)
		{
		/* --- GHIDRA: InitChannels ---
		void Core_Application_Managers_NotificationManager__InitChannels
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\0') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x28;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x27;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x26;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x25;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x24;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x01') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x23;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x29;
		  return;
		}
		*/

		}

		// Token: 0x04003A18 RID: 14872
		[Token(Token = "0x4003A18")]
		[FieldOffset(Offset = "0x10")]
		private INotificationManager _implementation;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_NotificationManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a832 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a832 = '\x01';
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
		void Core_Application_Managers_NotificationManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a833 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a833 = '\x01';
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
		void Core_Application_Managers_NotificationManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a834 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a834 = '\x01';
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Application_Managers_NotificationManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a835 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Platforms_WebGL_Notifications_NotificationManagerImplementation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_NotificationManager_ImplementationOnDeinitCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_NotificationManager_ImplementationOnInitCompleteEvent__
		              );
		    DAT_ram_00a5a835 = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417
		                            (
		                            Platforms_WebGL_Notifications_NotificationManagerImplementation_TypeInfo
		                            );
		  *(int **)(param1 + 0x10) = piVar2;
		  uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Application_Managers_NotificationManager_ImplementationOnInitCompleteEvent__
		             ,0);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8127868e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_IBaseManager_TypeInfo,0);
		code_r0x8127868e:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar3,puVar4[1]);
		  piVar2 = *(int **)(param1 + 0x10);
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Application_Managers_NotificationManager_ImplementationOnDeinitCompleteEvent__
		             ,0);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x81278730;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_IBaseManager_TypeInfo,2);
		code_r0x81278730:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar3,puVar4[1]);
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_NotificationManager__get_Name(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a839 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_NotificationManager_ImplementationOnDeinitCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_NotificationManager_ImplementationOnInitCompleteEvent__
		              );
		    DAT_ram_00a5a839 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Application_Managers_NotificationManager_ImplementationOnInitCompleteEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x8127c3d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_IBaseManager_TypeInfo,1);
		code_r0x8127c3d7:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Application_Managers_NotificationManager_ImplementationOnDeinitCompleteEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8127c479;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_IBaseManager_TypeInfo,3);
		code_r0x8127c479:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

}
