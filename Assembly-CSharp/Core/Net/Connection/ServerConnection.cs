using System;
using System.Threading;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EAF RID: 3759
	[Token(Token = "0x2000EAF")]
	public class ServerConnection : IConnection
	{
		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001299")]
		public static ServerConnection Instance
		{
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0xA817", Offset = "0xA817", VA = "0xA817")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B56")]
		[Address(RVA = "0xA818", Offset = "0xA818", VA = "0xA818")]
		private ServerConnection()
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x81cb42c1) */
		
		void Core_Net_Connection_ServerConnection___ctor(int param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a605df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Action_SrvAnswer___Action_SrvAnswer___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Action_SrvAnswer___Action_SrvAnswer___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Action_SrvAnswer___Action_SrvAnswer___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Net_Connection_ServerConnection___c__DisplayClass5_0__ServerEventReceived_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ServerConnection___c__DisplayClass5_0_TypeInfo);
		    DAT_ram_00a605df = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  sVar1 = *(short *)(param2 + 0xc);
		  iVar5 = *(int *)(param1 + 8);
		  if (DAT_ram_00a605c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		              );
		    DAT_ram_00a605c7 = '\x01';
		  }
		  iVar2 = System_Collections_Generic_Dictionary_short__object___Clear
		                    (*(undefined4 *)(iVar5 + 0x28),(int)sVar1,
		                     Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		                    );
		  if ((iVar2 == 0) ||
		     (iVar5 = System_Collections_Generic_Dictionary_short__object___get_Count
		                        (*(undefined4 *)(iVar5 + 0x28),(int)sVar1,
		                         Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                        ), iVar5 == 0)) {
		    return;
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,iVar5,
		             Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_Action_SrvAnswer___Action_SrvAnswer___MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb440f;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Net_Connection_ServerConnection___c__DisplayClass5_0_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb440f;
		    }
		    *(ulonglong *)(iVar5 + 8) = CONCAT44(local_8,uStack_c);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Net_SrvCommand_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb440f;
		      }
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Threading_SendOrPostCallback_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb43f3:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb440f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x11,uVar3,iVar5,
		               Method_Core_Net_Connection_ServerConnection___c__DisplayClass5_0__ServerEventReceived_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb43f3;
		    iVar5 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (*(undefined4 *)(iVar5 + 0xe8),piVar4,uVar3,param2,*(undefined4 *)(iVar5 + 0xec));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar5 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb440f:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x12,&local_20);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0xA819", Offset = "0xA819", VA = "0xA819")]
		private void ServerEventReceived(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventReceived ---
		void Core_Net_Connection_ServerConnection__ServerEventReceived
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 8);
		  if (DAT_ram_00a605bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    DAT_ram_00a605bf = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ConnectionState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ConnectionState__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 8,iVar2,param1_00);
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

		// Token: 0x1400022B RID: 555
		// (add) Token: 0x06005B58 RID: 23384 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B59 RID: 23385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022B")]
		public event Action<ConnectionState> OnStateChangedEvent
		{
			[Token(Token = "0x6005B58")]
			[Address(RVA = "0xA81A", Offset = "0xA81A", VA = "0xA81A", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x6005B59")]
			[Address(RVA = "0xA81B", Offset = "0xA81B", VA = "0xA81B", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0xA81C", Offset = "0xA81C", VA = "0xA81C", Slot = "13")]
		public void Push(SrvCommand command)
		{
		/* --- GHIDRA: Push ---
		void Core_Net_Connection_ServerConnection__Push
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Net_Connection_AbstractConnection___ctor(*(undefined4 *)(param1 + 8),param2,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0xA81D", Offset = "0xA81D", VA = "0xA81D", Slot = "14")]
		public void AddServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		/* --- GHIDRA: AddServiceEventHandler ---
		void Core_Net_Connection_ServerConnection__AddServiceEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Net_Connection_AbstractConnection__AddServiceEventHandler
		            (*(undefined4 *)(param1 + 8),param2,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0xA81E", Offset = "0xA81E", VA = "0xA81E", Slot = "15")]
		public void RemoveServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		/* --- GHIDRA: RemoveServiceEventHandler ---
		void Core_Net_Connection_ServerConnection__RemoveServiceEventHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		            (*(int **)(param1 + 8),*(undefined4 *)(iVar1 + 0x15c));
		  return;
		}
		*/

		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0xA81F", Offset = "0xA81F", VA = "0xA81F", Slot = "16")]
		public void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Net_Connection_ServerConnection__Run(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 8),*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B5E")]
		[Address(RVA = "0xA820", Offset = "0xA820", VA = "0xA820", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06005B5F RID: 23391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B60 RID: 23392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129A")]
		public Uri Uri
		{
			[Token(Token = "0x6005B5F")]
			[Address(RVA = "0xA821", Offset = "0xA821", VA = "0xA821", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0xA822", Offset = "0xA822", VA = "0xA822", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06005B61 RID: 23393 RVA: 0x000103F8 File Offset: 0x0000E5F8
		// (set) Token: 0x06005B62 RID: 23394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129B")]
		public int WriteTimeout
		{
			[Token(Token = "0x6005B61")]
			[Address(RVA = "0xA823", Offset = "0xA823", VA = "0xA823", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B62")]
			[Address(RVA = "0xA824", Offset = "0xA824", VA = "0xA824", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06005B63 RID: 23395 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x06005B64 RID: 23396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700129C")]
		public int ReadTimeout
		{
			[Token(Token = "0x6005B63")]
			[Address(RVA = "0xA825", Offset = "0xA825", VA = "0xA825", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B64")]
			[Address(RVA = "0xA826", Offset = "0xA826", VA = "0xA826", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700129D")]
		public ConnectionState CurrentState
		{
			[Token(Token = "0x6005B65")]
			[Address(RVA = "0xA827", Offset = "0xA827", VA = "0xA827", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B66")]
		[Address(RVA = "0xA828", Offset = "0xA828", VA = "0xA828")]
		public void Setup(SynchronizationContext context, IProtocolMessageFactoriesRepository eventsMap, ILowResponseAbilityMonitor lowResponseAbilityMonitor)
		{
		}

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x0")]
		private static ServerConnection _instance;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x8")]
		private readonly AbstractConnection _currentConnection;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		void Core_Net_Connection_ServerConnection__get_Instance(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int param1_02;
		  
		  if (DAT_ram_00a605de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvAnswer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_PacketParser_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_Connection_ServerConnection_ServerEventReceived__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_WebSocketConnection_TypeInfo);
		    DAT_ram_00a605de = '\x01';
		  }
		  uVar3 = unnamed_function_1417(Core_Net_PacketParser_TypeInfo);
		  param1_01 = unnamed_function_1417(Core_Net_Connection_WebSocketConnection_TypeInfo);
		  if (DAT_ram_00a605e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_SrvCommand___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_SrvCommand__TypeInfo);
		    DAT_ram_00a605e7 = '\x01';
		  }
		  uVar4 = unnamed_function_1417(System_Collections_Generic_LinkedList_SrvCommand__TypeInfo);
		  *(undefined4 *)(param1_01 + 0x40) = uVar4;
		  Core_Net_Connection_AbstractConnection__set_IsRun
		            (param1_01,uVar3,s_MotionQ_w_ram_0000f9fc + 4,param1_01);
		  *(int *)(param1 + 8) = param1_01;
		  uVar3 = unnamed_function_1417(System_Action_SrvAnswer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Core_Net_Connection_ServerConnection_ServerEventReceived__,0);
		  if (DAT_ram_00a605c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvAnswer__TypeInfo);
		    DAT_ram_00a605c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1_01 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar4 = System_Action_SrvAnswer__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_SrvAnswer__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1_01 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnStateChangedEvent ---
		void Core_Net_Connection_ServerConnection__add_OnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 8);
		  if (DAT_ram_00a605c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    DAT_ram_00a605c0 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ConnectionState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ConnectionState__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnStateChangedEvent ---
		void Core_Net_Connection_ServerConnection__remove_OnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x150) * 4))
		            (*(int **)(param1 + 8),param2,*(undefined4 *)(iVar1 + 0x154));
		  return;
		}
		*/


		/* --- GHIDRA: get_Uri ---
		void Core_Net_Connection_ServerConnection__get_Uri(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x10) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_WriteTimeout ---
		void Core_Net_Connection_ServerConnection__get_WriteTimeout
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x14) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_ReadTimeout ---
		void Core_Net_Connection_ServerConnection__get_ReadTimeout
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x18) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_CurrentState ---
		void Core_Net_Connection_ServerConnection__get_CurrentState
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a605e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a605e0 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  **(undefined4 **)(Core_Net_SrvCommand_TypeInfo + 0x5c) = param2;
		  iVar1 = *(int *)(param1 + 8);
		  *(undefined4 *)(iVar1 + 0x24) = param4;
		  *(undefined4 *)(iVar1 + 0x20) = param3;
		  return;
		}
		*/

}
