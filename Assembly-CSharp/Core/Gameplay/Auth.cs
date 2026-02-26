using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Gameplay
{
	// Token: 0x02001118 RID: 4376
	[Token(Token = "0x2001118")]
	public class Auth : IAuth, IDisposable
	{
		// Token: 0x06006686 RID: 26246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006686")]
		[Address(RVA = "0xB20A", Offset = "0xB20A", VA = "0xB20A", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Gameplay_Auth__ToString(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnLoginErrorEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnLoginSuccessEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnRegisterErrorEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnRegisterSuccessEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnUserIdChangedEvent__);
		    DAT_ram_00a5a908 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnUserIdChangedEvent__,0);
		  if (DAT_ram_00a5a93f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    DAT_ram_00a5a93f = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x18);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = func_ii_7048(iVar3,uVar5,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo), iVar4 == 0))
		    break;
		    iVar4 = func_ii_4329(iVar7 + 0x18,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_IAuthDataProvider__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnLoginSuccessEvent__,0);
		      if (DAT_ram_00a5a937 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		        DAT_ram_00a5a937 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 8);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_IAuthDataProvider__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_IAuthDataProvider__TypeInfo), iVar4 == 0))
		        break;
		        iVar4 = func_ii_4329(iVar7 + 8,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          iVar7 = *(int *)(param1 + 0x14);
		          uVar5 = unnamed_function_1417(System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo)
		          ;
		          System_Action_Int32Enum__Int32Enum___Invoke
		                    (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnLoginErrorEvent__,0);
		          if (DAT_ram_00a5a93b == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		            DAT_ram_00a5a93b = '\x01';
		          }
		          iVar3 = *(int *)(iVar7 + 0x10);
		          while( true ) {
		            iVar4 = 0;
		            iVar6 = func_ii_7048(iVar3,uVar5,0);
		            uVar2 = System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo;
		            if ((iVar6 != 0) &&
		               (iVar4 = func_ii_1082(iVar6,
		                                     System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo),
		               iVar4 == 0)) break;
		            iVar4 = func_ii_4329(iVar7 + 0x10,iVar4,iVar3);
		            bVar1 = iVar4 == iVar3;
		            iVar3 = iVar4;
		            if (bVar1) {
		              iVar7 = *(int *)(param1 + 0x14);
		              uVar5 = unnamed_function_1417(System_Action_IAuthDataProvider__TypeInfo);
		              UnityEngine_UIElements_VisualElement__get_layout
		                        (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnRegisterSuccessEvent__,
		                         0);
		              if (DAT_ram_00a5a939 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		                DAT_ram_00a5a939 = '\x01';
		              }
		              iVar3 = *(int *)(iVar7 + 0xc);
		              while( true ) {
		                iVar4 = 0;
		                iVar6 = func_ii_7048(iVar3,uVar5,0);
		                uVar2 = System_Action_IAuthDataProvider__TypeInfo;
		                if ((iVar6 != 0) &&
		                   (iVar4 = func_ii_1082(iVar6,System_Action_IAuthDataProvider__TypeInfo),
		                   iVar4 == 0)) break;
		                iVar4 = func_ii_4329(iVar7 + 0xc,iVar4,iVar3);
		                bVar1 = iVar4 == iVar3;
		                iVar3 = iVar4;
		                if (bVar1) {
		                  iVar7 = *(int *)(param1 + 0x14);
		                  uVar5 = unnamed_function_1417
		                                    (System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo)
		                  ;
		                  System_Action_Int32Enum__Int32Enum___Invoke
		                            (uVar5,param1,
		                             Method_Core_Gameplay_Auth_AuthManagerOnRegisterErrorEvent__,0);
		                  if (DAT_ram_00a5a93d == '\0') {
		                    Mono_Security_ASN1__get_Item
		                              (&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		                    DAT_ram_00a5a93d = '\x01';
		                  }
		                  iVar3 = *(int *)(iVar7 + 0x14);
		                  while( true ) {
		                    iVar4 = 0;
		                    iVar6 = func_ii_7048(iVar3,uVar5,0);
		                    uVar2 = System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo;
		                    if ((iVar6 != 0) &&
		                       (iVar4 = func_ii_1082(iVar6,
		                                             System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo
		                                            ), iVar4 == 0)) break;
		                    iVar4 = func_ii_4329(iVar7 + 0x14,iVar4,iVar3);
		                    bVar1 = iVar4 == iVar3;
		                    iVar3 = iVar4;
		                    if (bVar1) {
		                      *(int *)(param1 + 0x10) = *(int *)(param1 + 0x10) + -1;
		                      Core_Gameplay_Auth__InitCompleted(param1,iVar4);
		                      *(undefined4 *)(param1 + 0x18) = 0;
		                      return;
		                    }
		                  }
		                  System_Activator__CreateInstance(iVar6,uVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		              }
		              System_Activator__CreateInstance(iVar6,uVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006687")]
		[Address(RVA = "0xB20B", Offset = "0xB20B", VA = "0xB20B", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Auth__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a909 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnLoginErrorEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnLoginSuccessEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnRegisterErrorEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnRegisterSuccessEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_AuthManagerOnUserIdChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Auth_TypeInfo);
		    DAT_ram_00a5a909 = '\x01';
		  }
		  iVar7 = **(int **)(Core_Gameplay_Auth_TypeInfo + 0x5c) + 1;
		  **(int **)(Core_Gameplay_Auth_TypeInfo + 0x5c) = iVar7;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(int *)(param1 + 8) = iVar7;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  Core_Gameplay_Auth__AuthManagerOnUserIdChangedEvent(param1,param2);
		  Core_Gameplay_Auth__CreateGameManagers(param1,param2);
		  iVar7 = *(int *)(param1 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnUserIdChangedEvent__,0);
		  if (DAT_ram_00a5a93e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    DAT_ram_00a5a93e = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x18);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		    uVar2 = System_Action_ulong__TypeInfo;
		    if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo), iVar4 == 0))
		    break;
		    iVar4 = func_ii_4329(iVar7 + 0x18,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_IAuthDataProvider__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnLoginSuccessEvent__,0);
		      if (DAT_ram_00a5a936 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		        DAT_ram_00a5a936 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 8);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_IAuthDataProvider__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_IAuthDataProvider__TypeInfo), iVar4 == 0))
		        break;
		        iVar4 = func_ii_4329(iVar7 + 8,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          iVar7 = *(int *)(param1 + 0x14);
		          uVar5 = unnamed_function_1417(System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo)
		          ;
		          System_Action_Int32Enum__Int32Enum___Invoke
		                    (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnLoginErrorEvent__,0);
		          if (DAT_ram_00a5a93a == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		            DAT_ram_00a5a93a = '\x01';
		          }
		          iVar3 = *(int *)(iVar7 + 0x10);
		          while( true ) {
		            iVar4 = 0;
		            iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		            uVar2 = System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo;
		            if ((iVar6 != 0) &&
		               (iVar4 = func_ii_1082(iVar6,
		                                     System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo),
		               iVar4 == 0)) break;
		            iVar4 = func_ii_4329(iVar7 + 0x10,iVar4,iVar3);
		            bVar1 = iVar4 == iVar3;
		            iVar3 = iVar4;
		            if (bVar1) {
		              iVar7 = *(int *)(param1 + 0x14);
		              uVar5 = unnamed_function_1417(System_Action_IAuthDataProvider__TypeInfo);
		              UnityEngine_UIElements_VisualElement__get_layout
		                        (uVar5,param1,Method_Core_Gameplay_Auth_AuthManagerOnRegisterSuccessEvent__,
		                         0);
		              if (DAT_ram_00a5a938 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		                DAT_ram_00a5a938 = '\x01';
		              }
		              iVar3 = *(int *)(iVar7 + 0xc);
		              while( true ) {
		                iVar4 = 0;
		                iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		                uVar2 = System_Action_IAuthDataProvider__TypeInfo;
		                if ((iVar6 != 0) &&
		                   (iVar4 = func_ii_1082(iVar6,System_Action_IAuthDataProvider__TypeInfo),
		                   iVar4 == 0)) break;
		                iVar4 = func_ii_4329(iVar7 + 0xc,iVar4,iVar3);
		                bVar1 = iVar4 == iVar3;
		                iVar3 = iVar4;
		                if (bVar1) {
		                  iVar7 = *(int *)(param1 + 0x14);
		                  uVar5 = unnamed_function_1417
		                                    (System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo)
		                  ;
		                  System_Action_Int32Enum__Int32Enum___Invoke
		                            (uVar5,param1,
		                             Method_Core_Gameplay_Auth_AuthManagerOnRegisterErrorEvent__,0);
		                  if (DAT_ram_00a5a93c == '\0') {
		                    Mono_Security_ASN1__get_Item
		                              (&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		                    DAT_ram_00a5a93c = '\x01';
		                  }
		                  iVar3 = *(int *)(iVar7 + 0x14);
		                  while( true ) {
		                    iVar4 = 0;
		                    iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		                    uVar2 = System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo;
		                    if ((iVar6 != 0) &&
		                       (iVar4 = func_ii_1082(iVar6,
		                                             System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo
		                                            ), iVar4 == 0)) break;
		                    iVar4 = func_ii_4329(iVar7 + 0x14,iVar4,iVar3);
		                    bVar1 = iVar4 == iVar3;
		                    iVar3 = iVar4;
		                    if (bVar1) {
		                      return;
		                    }
		                  }
		                  System_Activator__CreateInstance(iVar6,uVar2);
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		              }
		              System_Activator__CreateInstance(iVar6,uVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006688")]
		[Address(RVA = "0xB20C", Offset = "0xB20C", VA = "0xB20C")]
		public Auth(IApp app)
		{
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DF")]
		public LoggedManager LoggedManager
		{
			[Token(Token = "0x6006689")]
			[Address(RVA = "0xB20D", Offset = "0xB20D", VA = "0xB20D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600668A")]
			[Address(RVA = "0xB20E", Offset = "0xB20E", VA = "0xB20E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600668C RID: 26252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E0")]
		public IApp Application
		{
			[Token(Token = "0x600668B")]
			[Address(RVA = "0xB20F", Offset = "0xB20F", VA = "0xB20F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600668C")]
			[Address(RVA = "0xB210", Offset = "0xB210", VA = "0xB210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668D")]
		[Address(RVA = "0xB211", Offset = "0xB211", VA = "0xB211")]
		private void AuthManagerOnRegisterErrorEvent(RegisterCmd.Types.Result result, SigninRecord signinRecord)
		{
		/* --- GHIDRA: AuthManagerOnRegisterErrorEvent ---
		void Core_Gameplay_Auth__AuthManagerOnRegisterErrorEvent(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a90b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a5a90b = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8128f8ad;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,3);
		code_r0x8128f8ad:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x24),0);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128f936;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8128f936:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,*(uint *)(iVar5 + 0x24) & 1,0);
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x8128f9c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,8);
		code_r0x8128f9c7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 8) + 0x14);
		  if (iVar5 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar3,param3_00,param2,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1_00,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600668E RID: 26254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668E")]
		[Address(RVA = "0xB212", Offset = "0xB212", VA = "0xB212")]
		private void AuthManagerOnRegisterSuccessEvent(IAuthDataProvider provider)
		{
		/* --- GHIDRA: AuthManagerOnRegisterSuccessEvent ---
		void Core_Gameplay_Auth__AuthManagerOnRegisterSuccessEvent(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a90c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a5a90c = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8128faf9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,3);
		code_r0x8128faf9:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar5 + 0x24),0);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128fb82;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8128fb82:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,*(uint *)(iVar5 + 0x24) & 1,0);
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x8128fc13;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,8);
		code_r0x8128fc13:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 8) + 8);
		  if (iVar5 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar3,param3_00,param2,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1_00,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668F")]
		[Address(RVA = "0xB213", Offset = "0xB213", VA = "0xB213")]
		private void AuthManagerOnLoginSuccessEvent(IAuthDataProvider provider)
		{
		/* --- GHIDRA: AuthManagerOnLoginSuccessEvent ---
		void Core_Gameplay_Auth__AuthManagerOnLoginSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a90d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_LoginErrorEventArgs_TypeInfo);
		    DAT_ram_00a5a90d = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x8128fd32;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x8128fd32:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 8) + 0xc);
		  if (iVar3 != 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_LoginErrorEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,param2_00,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006690 RID: 26256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006690")]
		[Address(RVA = "0xB214", Offset = "0xB214", VA = "0xB214")]
		private void AuthManagerOnLoginErrorEvent(LoginCmd.Types.Result loginResult, SigninRecord signinRecord)
		{
		/* --- GHIDRA: AuthManagerOnLoginErrorEvent ---
		void Core_Gameplay_Auth__AuthManagerOnLoginErrorEvent
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a90e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5a90e = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x138);
		        goto code_r0x8128fe53;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8128fe53:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined8 *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x1c) + 0x10) + 0x40) + 8) = param2;
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x138);
		        goto code_r0x8128fee4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8128fee4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(*(int *)(iVar4 + 0x1c) + 0x10);
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x138);
		        goto code_r0x8128ff6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8128ff6f:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  UI_Preloader_PreloaderView__SetProgress
		            (uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x1c) + 0x10) + 0x40),0);
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81290003;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,3);
		code_r0x81290003:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar4 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,*(uint *)(*(int *)(*(int *)(param1 + 0x14) + 0x30) + 0x24) & 1,0);
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x812900a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,8);
		code_r0x812900a3:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = *(int *)(*(int *)(*(int *)(iVar4 + 0x10) + 8) + 0x1c);
		  if (iVar4 != 0) {
		    uVar5 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = *(undefined4 *)(param1 + 0x14);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_BaseAuthEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar5,param3_00,param4,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1_00,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006691")]
		[Address(RVA = "0xB215", Offset = "0xB215", VA = "0xB215")]
		private void AuthManagerOnUserIdChangedEvent(ulong userId)
		{
		/* --- GHIDRA: AuthManagerOnUserIdChangedEvent ---
		void Core_Gameplay_Auth__AuthManagerOnUserIdChangedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int param1_01;
		  int iVar8;
		  
		  if (DAT_ram_00a5a90f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_LoggedManager_TypeInfo);
		    DAT_ram_00a5a90f = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_IBaseManager__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_IBaseManager___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x168);
		        goto code_r0x8128ebd5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0x15);
		code_r0x8128ebd5:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x8128ec5a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x16);
		code_r0x8128ec5a:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x8128ecdf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,10);
		code_r0x8128ecdf:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar5 + 0x10);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		        goto code_r0x8128ed67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0xc);
		code_r0x8128ed67:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(iVar5 + 0x28);
		  iVar5 = unnamed_function_1417(Core_Gameplay_Managers_LoggedManager_TypeInfo);
		  if (DAT_ram_00a5a944 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a944 = '\x01';
		  }
		  *(undefined4 *)(iVar5 + 0x3c) = uVar4;
		  *(undefined4 *)(iVar5 + 0x38) = uVar2;
		  *(int **)(iVar5 + 0x34) = param1_00;
		  *(undefined4 *)(iVar5 + 0x2c) = uVar7;
		  iVar8 = *piVar6;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x8128ee35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,
		                                Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,1)
		  ;
		code_r0x8128ee35:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar6,iVar5,puVar3[1]);
		  *(int *)(param1 + 0x14) = iVar5;
		  iVar8 = Method_System_Collections_Generic_List_IBaseManager__Add__;
		  param1_01 = *(int *)(param1 + 0xc);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar1 = *(uint *)(param1_01 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = iVar5;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006692")]
		[Address(RVA = "0xB216", Offset = "0xB216", VA = "0xB216")]
		private void CreateGameManagers()
		{
		/* --- GHIDRA: CreateGameManagers ---
		void Core_Gameplay_Auth__CreateGameManagers(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  uint *puVar3;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a5a910 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_168);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28605);
		    DAT_ram_00a5a910 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0xc) + 0xc) + -1 < *(int *)(param1 + 0x10)) {
		    if (DAT_ram_00a5a912 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_GameResolver_TypeInfo);
		      DAT_ram_00a5a912 = '\x01';
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    iVar4 = unnamed_function_1417(Core_Gameplay_GameResolver_TypeInfo);
		    *(undefined4 *)(iVar4 + 8) = uVar2;
		    Core_Gameplay_GameResolver__Resolve(iVar4,*(undefined4 *)(param1 + 0x14),iVar4);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                               (*(int *)(param1 + 0xc),*(int *)(param1 + 0x10),
		                                Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		  uVar2 = func_ii_4419(StringLiteral_28605,param1,0);
		  param2_00 = func_ii_4443(param1 + 0x10,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x8128effc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x8128effc:
		  param4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = System_Int32__ToString(uVar2,param2_00,StringLiteral_168,param4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_Auth_ManagerInitComplete__,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128f0ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,0);
		code_r0x8128f0ce:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8128f14a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,4);
		code_r0x8128f14a:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006693 RID: 26259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006693")]
		[Address(RVA = "0xB217", Offset = "0xB217", VA = "0xB217")]
		private void HandleManagersQueue()
		{
		/* --- GHIDRA: HandleManagersQueue ---
		void Core_Gameplay_Auth__HandleManagersQueue(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a911 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_ManagerInitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28606);
		    DAT_ram_00a5a911 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_Auth_ManagerInitComplete__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x81290312;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,1);
		code_r0x81290312:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar2 = func_ii_4419(StringLiteral_28606,param1,0);
		  param2_00 = func_ii_4443(param1 + 0x10,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  *(int *)(param1 + 0x10) = *(int *)(param1 + 0x10) + 1;
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x138);
		        goto code_r0x812903e0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0xf);
		code_r0x812903e0:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  Preloading_Preloader__Show
		            (*(undefined4 *)(iVar4 + 0x1c),
		             (float)*(int *)(param1 + 0x10) / (float)*(int *)(*(int *)(param1 + 0xc) + 0xc),2,0);
		  Core_Gameplay_Auth__CreateGameManagers(param1,puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006694")]
		[Address(RVA = "0xB218", Offset = "0xB218", VA = "0xB218")]
		private void ManagerInitComplete(IBaseManager manager)
		{
		/* --- GHIDRA: ManagerInitComplete ---
		void Core_Gameplay_Auth__ManagerInitComplete(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a912 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameResolver_TypeInfo);
		    DAT_ram_00a5a912 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(Core_Gameplay_GameResolver_TypeInfo);
		  *(undefined4 *)(param1_00 + 8) = uVar1;
		  Core_Gameplay_GameResolver__Resolve(param1_00,*(undefined4 *)(param1 + 0x14),param1);
		  return;
		}
		*/

		}

		// Token: 0x06006695 RID: 26261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006695")]
		[Address(RVA = "0xB219", Offset = "0xB219", VA = "0xB219")]
		private void InitCompleted()
		{
		/* --- GHIDRA: InitCompleted ---
		void Core_Gameplay_Auth__InitCompleted(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  uint *puVar3;
		  undefined4 param4;
		  int iVar4;
		  
		  if (DAT_ram_00a5a913 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_ManagerDeinitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28604);
		    Mono_Security_ASN1__get_Item(&StringLiteral_168);
		    DAT_ram_00a5a913 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) < 0) {
		    if (DAT_ram_00a5a915 == '\0') {
		      Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		      Mono_Security_ASN1__get_Item(&StringLiteral_28600);
		      DAT_ram_00a5a915 = '\x01';
		    }
		    uVar2 = func_ii_4419(StringLiteral_28600,param1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                               (*(undefined4 *)(param1 + 0xc),*(int *)(param1 + 0x10),
		                                Method_System_Collections_Generic_List_IBaseManager__get_Item__);
		  uVar2 = func_ii_4419(StringLiteral_28604,param1,0);
		  param2_00 = func_ii_4443(param1 + 0x10,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x8128e36d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x8128e36d:
		  param4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = System_Int32__ToString(uVar2,param2_00,StringLiteral_168,param4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_Auth_ManagerDeinitComplete__,0);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8128e43f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,2);
		code_r0x8128e43f:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8128e4bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,5);
		code_r0x8128e4bb:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006696")]
		[Address(RVA = "0xB21A", Offset = "0xB21A", VA = "0xB21A")]
		private void HandleDeinitManagersQueue()
		{
		/* --- GHIDRA: HandleDeinitManagersQueue ---
		void Core_Gameplay_Auth__HandleDeinitManagersQueue(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a914 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Auth_ManagerDeinitComplete__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28599);
		    DAT_ram_00a5a914 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_Auth_ManagerDeinitComplete__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81290540;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,3);
		code_r0x81290540:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar2 = func_ii_4419(StringLiteral_28599,param1,0);
		  param2_00 = func_ii_4443(param1 + 0x10,0);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  *(int *)(param1 + 0x10) = *(int *)(param1 + 0x10) + -1;
		  Core_Gameplay_Auth__InitCompleted(param1,uVar2);
		  return;
		}
		*/

		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006697")]
		[Address(RVA = "0xB21B", Offset = "0xB21B", VA = "0xB21B")]
		private void ManagerDeinitComplete(IBaseManager manager)
		{
		/* --- GHIDRA: ManagerDeinitComplete ---
		void Core_Gameplay_Auth__ManagerDeinitComplete(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a915 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28600);
		    DAT_ram_00a5a915 = '\x01';
		  }
		  param1_00 = func_ii_4419(StringLiteral_28600,param1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006698")]
		[Address(RVA = "0xB21C", Offset = "0xB21C", VA = "0xB21C")]
		private void DeinitCompleted()
		{
		}

		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		[FieldOffset(Offset = "0x0")]
		private static int _instanceCount;

		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x8")]
		public readonly int InstanceIndex;

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0xC")]
		private List<IBaseManager> _managers;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x10")]
		private int _currentIndex;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Application ---
		void Core_Gameplay_Auth__set_Application
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a90a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AuthScope_RegisterErrorEventArgs_TypeInfo);
		    DAT_ram_00a5a90a = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x8128f784;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x8128f784:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 8) + 0x18);
		  if (iVar3 != 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_AuthScope_RegisterErrorEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,param2_00,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

}
