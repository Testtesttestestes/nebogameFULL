using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Application.Managers.Connection;
using Core.Gameplay.Managers.Configuration;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Auth2;
using Protocol.Consts;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001134 RID: 4404
	[Token(Token = "0x2001134")]
	public class LoggedManager : IAuthDataProvider, ILoginProvider, IRegistrationProvider, ILoggedUserIdSetter, IBaseManager
	{
		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001524")]
		public string Name
		{
			[Token(Token = "0x6006724")]
			[Address(RVA = "0xB255", Offset = "0xB255", VA = "0xB255", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400024D RID: 589
		// (add) Token: 0x06006725 RID: 26405 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006726 RID: 26406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024D")]
		public event Action<IAuthDataProvider> LoginSuccessEvent
		{
			[Token(Token = "0x6006725")]
			[Address(RVA = "0xB256", Offset = "0xB256", VA = "0xB256")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006726")]
			[Address(RVA = "0xB257", Offset = "0xB257", VA = "0xB257")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400024E RID: 590
		// (add) Token: 0x06006727 RID: 26407 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006728 RID: 26408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024E")]
		public event Action<IAuthDataProvider> RegisterSuccessEvent
		{
			[Token(Token = "0x6006727")]
			[Address(RVA = "0xB258", Offset = "0xB258", VA = "0xB258")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006728")]
			[Address(RVA = "0xB259", Offset = "0xB259", VA = "0xB259")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400024F RID: 591
		// (add) Token: 0x06006729 RID: 26409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672A RID: 26410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400024F")]
		public event Action<LoginCmd.Types.Result, SigninRecord> LoginErrorEvent
		{
			[Token(Token = "0x6006729")]
			[Address(RVA = "0xB25A", Offset = "0xB25A", VA = "0xB25A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672A")]
			[Address(RVA = "0xB25B", Offset = "0xB25B", VA = "0xB25B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000250 RID: 592
		// (add) Token: 0x0600672B RID: 26411 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672C RID: 26412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000250")]
		public event Action<RegisterCmd.Types.Result, SigninRecord> RegisterErrorEvent
		{
			[Token(Token = "0x600672B")]
			[Address(RVA = "0xB25C", Offset = "0xB25C", VA = "0xB25C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672C")]
			[Address(RVA = "0xB25D", Offset = "0xB25D", VA = "0xB25D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000251 RID: 593
		// (add) Token: 0x0600672D RID: 26413 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600672E RID: 26414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000251")]
		public event Action<ulong> UserIdChangedEvent
		{
			[Token(Token = "0x600672D")]
			[Address(RVA = "0xB25E", Offset = "0xB25E", VA = "0xB25E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600672E")]
			[Address(RVA = "0xB25F", Offset = "0xB25F", VA = "0xB25F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000252 RID: 594
		// (add) Token: 0x0600672F RID: 26415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006730 RID: 26416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000252")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600672F")]
			[Address(RVA = "0xB260", Offset = "0xB260", VA = "0xB260", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006730")]
			[Address(RVA = "0xB261", Offset = "0xB261", VA = "0xB261", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000253 RID: 595
		// (add) Token: 0x06006731 RID: 26417 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006732 RID: 26418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000253")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006731")]
			[Address(RVA = "0xB262", Offset = "0xB262", VA = "0xB262", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006732")]
			[Address(RVA = "0xB263", Offset = "0xB263", VA = "0xB263", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x000137D0 File Offset: 0x000119D0
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001525")]
		public int SuccessLoginCount
		{
			[Token(Token = "0x6006733")]
			[Address(RVA = "0xB264", Offset = "0xB264", VA = "0xB264", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006734")]
			[Address(RVA = "0xB265", Offset = "0xB265", VA = "0xB265")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006736 RID: 26422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001526")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x6006735")]
			[Address(RVA = "0xB266", Offset = "0xB266", VA = "0xB266")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006736")]
			[Address(RVA = "0xB267", Offset = "0xB267", VA = "0xB267")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06006737 RID: 26423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006738 RID: 26424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001527")]
		public AuthData AuthData
		{
			[Token(Token = "0x6006737")]
			[Address(RVA = "0xB268", Offset = "0xB268", VA = "0xB268", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006738")]
			[Address(RVA = "0xB269", Offset = "0xB269", VA = "0xB269")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006739")]
		[Address(RVA = "0xB26A", Offset = "0xB26A", VA = "0xB26A")]
		public LoggedManager(IApp app, IGameRestart gameRestart, IGameResolver gameResolver, IPlatformConfigurationProvider configurationProvider, IRecoveryConnection recoveryConnection)
		{
		/* --- GHIDRA: <HandleMoveUserEvent>b__45_0 ---
		void Core_Gameplay_Managers_LoggedManager___HandleMoveUserEvent_b__45_0
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a5a952 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameResolver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a952 = '\x01';
		  }
		  if (*(int *)(param3 + 0xc) == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    if (piVar3 != (int *)0x0) {
		      uVar1 = 0;
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a0);
		            goto code_r0x81298b1b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x81298b1b:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      if (iVar4 == 0) {
		        piVar3 = *(int **)(param1 + 0x38);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar1 = 0;
		        uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		            {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81298bde;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x81298bde:
		        (**(code **)((ulonglong)*puVar2 * 4))(auStack_8,piVar3,uVar5,puVar2[1]);
		      }
		      else {
		        piVar3 = *(int **)(param1 + 0x3c);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        uVar1 = 0;
		        uVar5 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGameResolver_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		               ) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81298c8e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGameResolver_TypeInfo,0);
		code_r0x81298c8e:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar3,uVar5,puVar2[1]);
		      }
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_LoggedManager___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a945 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDictionariesUpdatedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MoveUserEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_LoggedManager_HandleMoveUserEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_LoggedManager_OnDictionariesUpdatedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5a945 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_MoveUserEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Core_Gameplay_Managers_LoggedManager_HandleMoveUserEvent__,0);
		  ServicesNamespace_Auth2Service___ctor(uVar2,uVar1,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoDictionariesUpdatedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_Managers_LoggedManager_OnDictionariesUpdatedEvent__,0
		            );
		  ServicesNamespace_MainService__remove_ExpChangedEvent(uVar1,uVar2,0);
		  *(undefined4 *)(param1 + 0x24) = 0;
		  *(undefined8 *)(param1 + 0x2c) = 0;
		  uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  if (DAT_ram_00a5aa03 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5aa03 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8) = uVar1;
		  iVar3 = *(int *)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673A")]
		[Address(RVA = "0xB26B", Offset = "0xB26B", VA = "0xB26B", Slot = "14")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_LoggedManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a946 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager__Init_d__43___
		              );
		    DAT_ram_00a5a946 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_40,0);
		  local_24 = local_38;
		  local_30 = 0xffffffff;
		  local_2c = local_40;
		  local_1c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_LoggedManager___HandleMoveUserEvent_b__45_0_d_
		            (&local_2c,&local_30,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager__Init_d__43___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600673B RID: 26427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673B")]
		[Address(RVA = "0xB26C", Offset = "0xB26C", VA = "0xB26C", Slot = "13")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_LoggedManager__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a947 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictNameSource_TypeInfo);
		    DAT_ram_00a5a947 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0xc);
		  param1_00 = *(int **)(*(int *)(param1 + 0x30) + 0x38);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Core_Gameplay_Managers_DictNameSource_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Gameplay_Managers_DictNameSource_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Gameplay_Managers_DictNameSource_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Core_Gameplay_Managers_DictNameSource_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param1_00[3],iVar2,0);
		  if (iVar1 == 0) {
		    param1_00[3] = iVar2;
		    iVar2 = param1_00[2];
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600673C RID: 26428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673C")]
		[Address(RVA = "0xB26D", Offset = "0xB26D", VA = "0xB26D")]
		private void OnDictionariesUpdatedEvent(ProtoDictionariesUpdatedEvt evt)
		{
		/* --- GHIDRA: OnDictionariesUpdatedEvent ---
		void Core_Gameplay_Managers_LoggedManager__OnDictionariesUpdatedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *local_4;
		  
		  if (DAT_ram_00a5a948 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_LoggedManager__HandleMoveUserEvent_b__45_0__);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a5a948 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar4 = *(int **)(param1 + 0x34);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81297465;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,10);
		code_r0x81297465:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x812974ea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,5);
		code_r0x812974ea:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,&local_4,puVar2[1]);
		  piVar4 = local_4;
		  if (iVar5 != 0) {
		    uVar6 = *(undefined4 *)(param2 + 0xc);
		    uVar1 = 0;
		    uVar3 = unnamed_function_1417(System_Uri_TypeInfo);
		    UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar3,uVar6,0);
		    uVar7 = *(undefined4 *)(param2 + 0x10);
		    uVar6 = unnamed_function_1417
		                      (Core_Application_Managers_Configuration_Curator_CuratorData_TypeInfo);
		    Core_Application_Managers_Configuration_Curator_CuratorData___ctor(uVar6,uVar3,uVar7,0);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x812975b4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,3);
		code_r0x812975b4:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6,puVar2[1]);
		    piVar4 = local_4;
		    uVar1 = 0;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81297633;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,4);
		code_r0x81297633:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0x34);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x812976b6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xc);
		code_r0x812976b6:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    piVar4 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x8129773b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,2);
		code_r0x8129773b:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar7 = *(undefined4 *)(iVar5 + 8);
		    uVar6 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar6,param1,
		               Method_Core_Gameplay_Managers_LoggedManager__HandleMoveUserEvent_b__45_0__,0);
		    Core_Application_Managers_Connection_ConnectionManager__Init(uVar3,uVar7,uVar6,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673D")]
		[Address(RVA = "0xB26E", Offset = "0xB26E", VA = "0xB26E")]
		private void HandleMoveUserEvent(MoveUserEvt evt)
		{
		/* --- GHIDRA: HandleMoveUserEvent ---
		void Core_Gameplay_Managers_LoggedManager__HandleMoveUserEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int *param1_03;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  undefined8 uVar10;
		  uint uVar11;
		  byte local_1;
		  
		  if (DAT_ram_00a5a949 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AuthData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_LoggedManager_LoginCallbackInvoker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a5a949 = '\x01';
		  }
		  local_1 = 0;
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Gameplay_Managers_LoggedManager_LoginCallbackInvoker_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param1_01 + 100) +
		                    (uint)*(byte *)(
		                                   Core_Gameplay_Managers_LoggedManager_LoginCallbackInvoker_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Core_Gameplay_Managers_LoggedManager_LoginCallbackInvoker_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Core_Gameplay_Managers_LoggedManager_LoginCallbackInvoker_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_02 = *(int **)(param2 + 0x20);
		  if ((param1_02 != (int *)0x0) && (Protocol_Auth2_LoginCmd_Types_Ans_TypeInfo != *param1_02)) {
		    System_Activator__CreateInstance(param1_02,Protocol_Auth2_LoginCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_Billing_HvExpectedGetPaymentDataErrors___ctor
		                    (param1_02[3],&local_1,0);
		  if (iVar1 == 0) {
		    *(int *)(param1 + 0x28) = *(int *)(param1 + 0x28) + 1;
		    uVar11 = 0;
		    param1_03 = *(int **)(param1 + 0x34);
		    iVar1 = *param1_03;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8 + 4) * 8 + iVar1 + 0x128);
		          goto code_r0x8129792b;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar11);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_03,Core_Application_IApp_TypeInfo,0xd);
		code_r0x8129792b:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_03,puVar2[1]);
		    Core_Application_Managers_PlatformSigninManager__SigninToTargetProvider
		              (param1_00,param1_01[2],0);
		    iVar3 = param1_01[2];
		    iVar1 = unnamed_function_1417(Core_Gameplay_Managers_AuthData_TypeInfo);
		    iVar4 = param1_02[8];
		    iVar5 = param1_02[9];
		    iVar6 = param1_02[0xc];
		    iVar7 = param1_02[0xb];
		    iVar8 = param1_02[10];
		    iVar9 = param1_02[4];
		    uVar10 = *(undefined8 *)(param1_02 + 6);
		    if (DAT_ram_00a5a931 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictNameSource_TypeInfo);
		      DAT_ram_00a5a931 = '\x01';
		    }
		    *(int *)(iVar1 + 0x1c) = iVar6;
		    *(int *)(iVar1 + 0x18) = iVar8;
		    *(int *)(iVar1 + 0x14) = iVar9;
		    *(undefined8 *)(iVar1 + 8) = uVar10;
		    iVar6 = unnamed_function_1417(Core_Gameplay_Managers_DictNameSource_TypeInfo);
		    *(int *)(iVar6 + 0xc) = iVar7;
		    *(int *)(iVar1 + 0x24) = iVar4;
		    *(int *)(iVar1 + 0x38) = iVar6;
		    *(int *)(iVar1 + 0x10) = iVar5;
		    *(undefined1 *)(iVar1 + 0x28) = *(undefined1 *)((int)param1_02 + 0x35);
		    iVar4 = param1_02[3];
		    *(int *)(iVar1 + 0x34) = iVar3;
		    *(int *)(iVar1 + 0x2c) = iVar4;
		    *(char *)(iVar1 + 0x29) = (char)param1_02[0xd];
		    Core_Gameplay_Managers_LoggedManager__OnRegisterService(param1,iVar1,iVar1);
		    iVar1 = param1_01[3];
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_01,param1_02,*(undefined4 *)(iVar1 + 0x14));
		    }
		    param1_01[3] = 0;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_02[3],param1_01[2],
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		    Core_Gameplay_Managers_LoggedManager__HandleLoginService
		              (param1,param1_02[3],(uint)local_1,iVar1);
		    iVar1 = param1_01[3];
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_01,param1_02,*(undefined4 *)(iVar1 + 0x14));
		    }
		    param1_01[3] = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673E")]
		[Address(RVA = "0xB26F", Offset = "0xB26F", VA = "0xB26F")]
		private void HandleLoginService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleLoginService ---
		void Core_Gameplay_Managers_LoggedManager__HandleLoginService
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a94b == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_LoginCmd_Types_Result_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8762);
		    DAT_ram_00a5a94b = '\x01';
		  }
		  local_4 = param2;
		  uVar2 = func_ii_1081(Protocol_Auth2_LoginCmd_Types_Result_TypeInfo,&local_4);
		  param1_00 = *(int **)(param1 + 0x34);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x128);
		        goto code_r0x81297b50;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0xd);
		code_r0x81297b50:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_8762,uVar2,*(undefined4 *)(iVar4 + 0xc),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(uVar2,0);
		  if ((param3 != 0) && (iVar4 = *(int *)(param1 + 0x1c), iVar4 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600673F RID: 26431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673F")]
		[Address(RVA = "0x2288", Offset = "0x2288", VA = "0x2288")]
		private void HandleSigninFailed()
		{
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006740")]
		[Address(RVA = "0xB270", Offset = "0xB270", VA = "0xB270")]
		private void HandleLoginFailed(LoginCmd.Types.Result loginResult, bool isCanDoContinueAuthPipeline)
		{
		/* --- GHIDRA: HandleLoginFailed ---
		void Core_Gameplay_Managers_LoggedManager__HandleLoginFailed
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  undefined8 uVar11;
		  uint uVar12;
		  
		  if (DAT_ram_00a5a94c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_RegisterCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AuthData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_LoggedManager_RegisterCallbackInvoker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_SigninRecord_TypeInfo);
		    DAT_ram_00a5a94c = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Auth2_RegisterCmd_Types_Ans_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Auth2_RegisterCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_02 + 0xb8) <
		         (uint)*(byte *)(Core_Gameplay_Managers_LoggedManager_RegisterCallbackInvoker_TypeInfo +
		                        0xb8)) ||
		       (*(int *)(*(int *)(*param1_02 + 100) +
		                 (uint)*(byte *)(
		                                Core_Gameplay_Managers_LoggedManager_RegisterCallbackInvoker_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Core_Gameplay_Managers_LoggedManager_RegisterCallbackInvoker_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_02,Core_Gameplay_Managers_LoggedManager_RegisterCallbackInvoker_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = Core_Errors_Expected_Auth_ExpectedLoginErrors__HandleTestModeWindowOnClose_d__3__SetStateMachine
		                    (param1_01[3],0);
		  if (iVar1 == 0) {
		    *(int *)(param1 + 0x28) = *(int *)(param1 + 0x28) + 1;
		    uVar12 = 0;
		    iVar1 = unnamed_function_1417(Core_Application_Managers_SigninRecord_TypeInfo);
		    func_ii_9113(iVar1,0);
		    piVar3 = *(int **)(param1 + 0x34);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + iVar4 + 0x128);
		          goto code_r0x8129809c;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x8129809c:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar12 = 0;
		    piVar3 = *(int **)(iVar4 + 0xc);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x81298121;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,
		                                  2);
		code_r0x81298121:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(iVar4 + 0xc);
		    uVar12 = 0;
		    piVar3 = *(int **)(param1 + 0x34);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + iVar4 + 0x128);
		          goto code_r0x812981ac;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x812981ac:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar12 = 0;
		    piVar3 = *(int **)(iVar4 + 0xc);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x81298231;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,
		                                  2);
		code_r0x81298231:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(iVar4 + 0x10);
		    *(int *)(iVar1 + 0x14) = param1_01[10];
		    uVar12 = 0;
		    piVar3 = *(int **)(param1 + 0x34);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + iVar4 + 0x128);
		          goto code_r0x812982c6;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x812982c6:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    Core_Application_Managers_PlatformSigninManager__SigninToTargetProvider(param1_00,iVar1,0);
		    iVar4 = unnamed_function_1417(Core_Gameplay_Managers_AuthData_TypeInfo);
		    iVar5 = param1_01[8];
		    iVar6 = param1_01[9];
		    iVar7 = param1_01[0xd];
		    iVar8 = param1_01[0xc];
		    iVar9 = param1_01[0xb];
		    iVar10 = param1_01[4];
		    uVar11 = *(undefined8 *)(param1_01 + 6);
		    if (DAT_ram_00a5a931 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictNameSource_TypeInfo);
		      DAT_ram_00a5a931 = '\x01';
		    }
		    *(int *)(iVar4 + 0x1c) = iVar7;
		    *(int *)(iVar4 + 0x18) = iVar9;
		    *(int *)(iVar4 + 0x14) = iVar10;
		    *(undefined8 *)(iVar4 + 8) = uVar11;
		    iVar7 = unnamed_function_1417(Core_Gameplay_Managers_DictNameSource_TypeInfo);
		    *(int *)(iVar7 + 0xc) = iVar8;
		    *(int *)(iVar4 + 0x24) = iVar5;
		    *(int *)(iVar4 + 0x38) = iVar7;
		    *(int *)(iVar4 + 0x10) = iVar6;
		    *(int *)(iVar4 + 0x30) = param1_01[3];
		    iVar5 = param1_01[0xe];
		    *(int *)(iVar4 + 0x34) = iVar1;
		    *(char *)(iVar4 + 0x29) = (char)iVar5;
		    Core_Gameplay_Managers_LoggedManager__OnRegisterService(param1,iVar4,iVar4);
		    iVar1 = param1_02[5];
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_02,param1_01,*(undefined4 *)(iVar1 + 0x14));
		    param1_02[5] = 0;
		    iVar1 = *(int *)(param1 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  else {
		    iVar1 = param1_02[5];
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_02,param1_01,*(undefined4 *)(iVar1 + 0x14));
		    param1_02[5] = 0;
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_01[3],param1_02[2],
		                 *(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006741")]
		[Address(RVA = "0xB271", Offset = "0xB271", VA = "0xB271")]
		private void OnRegisterService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnRegisterService ---
		void Core_Gameplay_Managers_LoggedManager__OnRegisterService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a94d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3440);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14289);
		    DAT_ram_00a5a94d = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x30) = param2;
		  param1_00 = *(int **)(param1 + 0x2c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81297c83;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,4);
		code_r0x81297c83:
		  uVar1 = CONCAT44(in_register_20000014,param2);
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar1,puVar3[1]);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0x14);
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  if (DAT_ram_00a5aa03 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5aa03 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8) = uVar5;
		  uVar5 = func_ii_4419(StringLiteral_14289,*(undefined4 *)(param1 + 0x30),0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar5,0);
		  iVar6 = *(int *)(param1 + 0x30);
		  iVar4 = func_ii_4769(*(undefined4 *)(iVar6 + 0x14),0);
		  if (((iVar4 == 0) && (iVar4 = func_ii_4769(*(undefined4 *)(iVar6 + 0x18),0), iVar4 == 0)) &&
		     (*(longlong *)(iVar6 + 8) != 0)) {
		    iVar4 = *(int *)(param1 + 0x1c);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),CONCAT44(uVar2,param1),*(undefined4 *)(iVar4 + 0x14))
		      ;
		    }
		  }
		  else {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_3440,0);
		  }
		  iVar4 = *(int *)(param1 + 0x18);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined8 *)(*(int *)(param1 + 0x30) + 8),
		               *(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006742")]
		[Address(RVA = "0xB272", Offset = "0xB272", VA = "0xB272")]
		public void SetupAuthData([NotNull] AuthData data)
		{
		/* --- GHIDRA: SetupAuthData ---
		void Core_Gameplay_Managers_LoggedManager__SetupAuthData
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5a94e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a94e = '\x01';
		  }
		  param2_00 = *(int *)(param1 + 0x30);
		  *(undefined8 *)(param2_00 + 8) = param2;
		  Core_Gameplay_Managers_LoggedManager__OnRegisterService(param1,param2_00,param1);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar1 = ServicesNamespace_MainService__SellAllFromDrop(uVar1,param2,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006743")]
		[Address(RVA = "0xB273", Offset = "0xB273", VA = "0xB273", Slot = "8")]
		public void RequestSetUserId(ulong userId, Action<OpToken<IMessage, object>> callback)
		{
		/* --- GHIDRA: RequestSetUserId ---
		void Core_Gameplay_Managers_LoggedManager__RequestSetUserId
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a94f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager__Register_d__52___
		              );
		    DAT_ram_00a5a94f = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_40,0);
		  local_24 = local_38;
		  local_30 = 0xffffffff;
		  local_2c = local_40;
		  local_1c = param1;
		  local_18 = param2;
		  local_14 = param3;
		  local_10 = param4;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_LoggedManager__Init_d__43_
		            (&local_2c,&local_30,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager__Register_d__52___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006744 RID: 26436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006744")]
		[Address(RVA = "0xB274", Offset = "0xB274", VA = "0xB274", Slot = "7")]
		public void Register(string nick, uint aprId, Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> resultCallback)
		{
		/* --- GHIDRA: Register ---
		void Core_Gameplay_Managers_LoggedManager__Register(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a951 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager___HandleMoveUserEvent_b__45_0_d___
		              );
		    DAT_ram_00a5a951 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_HvBillingProvider__RunPurchase_d__9_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_LoggedManager___HandleMoveUserEvent_b__45_0_d___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006745")]
		[Address(RVA = "0x2283", Offset = "0x2283", VA = "0x2283", Slot = "6")]
		public void RequestLogin(ClientPlatform clientPlatform, SigninRecord record, Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> callback)
		{
		/* --- GHIDRA: RequestLogin ---
		int Core_Gameplay_Managers_LoggedManager__RequestLogin(int param1)
		
		{
		  int iVar1;
		  undefined4 param2;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int param1_00;
		  
		  puVar3 = *(undefined4 **)(param1 + 0x1c);
		  if (puVar3 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractService__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractService__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractService__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    puVar3 = *(undefined4 **)(param1 + 0x1c);
		    if (puVar3 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param1);
		      puVar3 = *(undefined4 **)(param1 + 0x1c);
		    }
		  }
		  uVar4 = *puVar3;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar4 = func_ii_2734(uVar4,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x5c) + 4),uVar4,
		                     Method_System_Collections_Generic_Dictionary_Type__AbstractService__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    iVar1 = System_Delegate__Combine(*(undefined4 *)(*(int *)(param1 + 0x1c) + 4));
		    param2 = Core_Net_Connection_SSLConnection___c__DisplayClass15_0___Send_b__0(0);
		    Core_Net_AbstractService__get_Connection(iVar1,param2,0);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Core_Net_ServiceFactory_TypeInfo + 0x5c);
		    *(undefined4 *)(iVar1 + 0xc) = *puVar3;
		    System_Reflection_FieldInfo__get_IsStatic
		              (puVar3[1],uVar4,iVar1,
		               Method_System_Collections_Generic_Dictionary_Type__AbstractService__Add__);
		  }
		  else {
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x5c) + 4),uVar4,
		                       Method_System_Collections_Generic_Dictionary_Type__AbstractService__get_Item__
		                      );
		  }
		  param1_00 = *(int *)(*(int *)(param1 + 0x1c) + 8);
		  if ((*(byte *)(param1_00 + 0xbd) & 1) == 0) {
		    param1_00 = func_ii_1079(param1_00);
		  }
		  if (iVar1 == 0) {
		    iVar2 = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(iVar1,param1_00);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(iVar1,param1_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0x24")]
		private Auth2Service _authService;

		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		[FieldOffset(Offset = "0x34")]
		public readonly IApp _app;

		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		[FieldOffset(Offset = "0x38")]
		private readonly IGameRestart _gameRestart;

		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		[FieldOffset(Offset = "0x3C")]
		private readonly IGameResolver _gameResolver;

		// Token: 0x02001135 RID: 4405
		[Token(Token = "0x2001135")]
		public class LoginCallbackInvoker
		{
			// Token: 0x06006748 RID: 26440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006748")]
			[Address(RVA = "0xB277", Offset = "0xB277", VA = "0xB277")]
			public LoginCallbackInvoker(SigninRecord record, Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> callback)
			{
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006749")]
			[Address(RVA = "0xB278", Offset = "0xB278", VA = "0xB278")]
			public void Invoke(LoginCmd.Types.Ans value)
			{
			}

			// Token: 0x04003715 RID: 14101
			[Token(Token = "0x4003715")]
			[FieldOffset(Offset = "0x8")]
			[NotNull]
			public readonly SigninRecord Record;

			// Token: 0x04003716 RID: 14102
			[Token(Token = "0x4003716")]
			[FieldOffset(Offset = "0xC")]
			[CanBeNull]
			private Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> _callback;
		}

		// Token: 0x02001136 RID: 4406
		[Token(Token = "0x2001136")]
		public class RegisterCallbackInvoker
		{
			// Token: 0x0600674A RID: 26442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600674A")]
			[Address(RVA = "0xB279", Offset = "0xB279", VA = "0xB279")]
			public RegisterCallbackInvoker([NotNull] string nick, uint aprId, [NotNull] SigninRecord record, [NotNull] Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> callback)
			{
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600674B")]
			[Address(RVA = "0xB27A", Offset = "0xB27A", VA = "0xB27A")]
			public void Invoke(RegisterCmd.Types.Ans value)
			{
			}

			// Token: 0x04003717 RID: 14103
			[Token(Token = "0x4003717")]
			[FieldOffset(Offset = "0x8")]
			[NotNull]
			public readonly SigninRecord Record;

			// Token: 0x04003718 RID: 14104
			[Token(Token = "0x4003718")]
			[FieldOffset(Offset = "0xC")]
			[NotNull]
			public readonly string Nick;

			// Token: 0x04003719 RID: 14105
			[Token(Token = "0x4003719")]
			[FieldOffset(Offset = "0x10")]
			public readonly uint AprId;

			// Token: 0x0400371A RID: 14106
			[Token(Token = "0x400371A")]
			[FieldOffset(Offset = "0x14")]
			[NotNull]
			private Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> _callback;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_LoggedManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a936 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    DAT_ram_00a5a936 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAuthDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthDataProvider__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_LoginSuccessEvent ---
		void Core_Gameplay_Managers_LoggedManager__add_LoginSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a937 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    DAT_ram_00a5a937 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAuthDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthDataProvider__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_LoginSuccessEvent ---
		void Core_Gameplay_Managers_LoggedManager__remove_LoginSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a938 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    DAT_ram_00a5a938 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAuthDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthDataProvider__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_RegisterSuccessEvent ---
		void Core_Gameplay_Managers_LoggedManager__add_RegisterSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a939 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthDataProvider__TypeInfo);
		    DAT_ram_00a5a939 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAuthDataProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthDataProvider__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_RegisterSuccessEvent ---
		void Core_Gameplay_Managers_LoggedManager__remove_RegisterSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		    DAT_ram_00a5a93a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_LoginErrorEvent ---
		void Core_Gameplay_Managers_LoggedManager__add_LoginErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo);
		    DAT_ram_00a5a93b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_LoginCmd_Types_Result__SigninRecord__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_LoginErrorEvent ---
		void Core_Gameplay_Managers_LoggedManager__remove_LoginErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		    DAT_ram_00a5a93c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: add_RegisterErrorEvent ---
		void Core_Gameplay_Managers_LoggedManager__add_RegisterErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo);
		    DAT_ram_00a5a93d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_RegisterCmd_Types_Result__SigninRecord__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RegisterErrorEvent ---
		void Core_Gameplay_Managers_LoggedManager__remove_RegisterErrorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    DAT_ram_00a5a93e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ulong__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ulong__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_UserIdChangedEvent ---
		void Core_Gameplay_Managers_LoggedManager__add_UserIdChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a93f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    DAT_ram_00a5a93f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ulong__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ulong__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UserIdChangedEvent ---
		void Core_Gameplay_Managers_LoggedManager__remove_UserIdChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a940 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a940 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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
		void Core_Gameplay_Managers_LoggedManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a941 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a941 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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
		void Core_Gameplay_Managers_LoggedManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a942 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a942 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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
		void Core_Gameplay_Managers_LoggedManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a943 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a943 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: set_AuthData ---
		void Core_Gameplay_Managers_LoggedManager__set_AuthData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               int *param6,undefined4 param7)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a944 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a944 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param4;
		  *(undefined4 *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  *(undefined4 *)(param1 + 0x2c) = param5;
		  iVar3 = *param6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x812901da;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param6,
		                                Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,1)
		  ;
		code_r0x812901da:
		  (**(code **)((ulonglong)*puVar2 * 4))(param6,param1,puVar2[1]);
		  return;
		}
		*/

}
