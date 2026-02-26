using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EA4 RID: 3748
	[Token(Token = "0x2000EA4")]
	public abstract class AbstractConnection : IConnection
	{
		// Token: 0x14000228 RID: 552
		// (add) Token: 0x06005B0D RID: 23309 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B0E RID: 23310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000228")]
		public event Action<ConnectionState> OnStateChangedEvent
		{
			[Token(Token = "0x6005B0D")]
			[Address(RVA = "0xA7E2", Offset = "0xA7E2", VA = "0xA7E2", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005B0E")]
			[Address(RVA = "0xA7E3", Offset = "0xA7E3", VA = "0xA7E3", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000229 RID: 553
		// (add) Token: 0x06005B0F RID: 23311 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005B10 RID: 23312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000229")]
		public event Action<SrvAnswer> OnServerEventReceived
		{
			[Token(Token = "0x6005B0F")]
			[Address(RVA = "0xA7E4", Offset = "0xA7E4", VA = "0xA7E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005B10")]
			[Address(RVA = "0xA7E5", Offset = "0xA7E5", VA = "0xA7E5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06005B11 RID: 23313 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B12 RID: 23314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128C")]
		public Uri Uri
		{
			[Token(Token = "0x6005B11")]
			[Address(RVA = "0xA7E6", Offset = "0xA7E6", VA = "0xA7E6", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B12")]
			[Address(RVA = "0xA7E7", Offset = "0xA7E7", VA = "0xA7E7", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06005B13 RID: 23315 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x06005B14 RID: 23316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128D")]
		public int WriteTimeout
		{
			[Token(Token = "0x6005B13")]
			[Address(RVA = "0xA7E8", Offset = "0xA7E8", VA = "0xA7E8", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B14")]
			[Address(RVA = "0xA7E9", Offset = "0xA7E9", VA = "0xA7E9", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x00010368 File Offset: 0x0000E568
		// (set) Token: 0x06005B16 RID: 23318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128E")]
		public int ReadTimeout
		{
			[Token(Token = "0x6005B15")]
			[Address(RVA = "0xA7EA", Offset = "0xA7EA", VA = "0xA7EA", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B16")]
			[Address(RVA = "0xA7EB", Offset = "0xA7EB", VA = "0xA7EB", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06005B17 RID: 23319 RVA: 0x00010380 File Offset: 0x0000E580
		// (set) Token: 0x06005B18 RID: 23320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700128F")]
		public int ReadBufferSize
		{
			[Token(Token = "0x6005B17")]
			[Address(RVA = "0xA7EC", Offset = "0xA7EC", VA = "0xA7EC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B18")]
			[Address(RVA = "0xA7ED", Offset = "0xA7ED", VA = "0xA7ED")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001290")]
		public IProtocolMessageFactoriesRepository MessageFactoriesRepository
		{
			[Token(Token = "0x6005B19")]
			[Address(RVA = "0xA7EE", Offset = "0xA7EE", VA = "0xA7EE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0xA7EF", Offset = "0xA7EF", VA = "0xA7EF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1C RID: 23324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001291")]
		public ILowResponseAbilityMonitor LowResponseAbilityMonitor
		{
			[Token(Token = "0x6005B1B")]
			[Address(RVA = "0xA7F0", Offset = "0xA7F0", VA = "0xA7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1C")]
			[Address(RVA = "0xA7F1", Offset = "0xA7F1", VA = "0xA7F1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005B1E RID: 23326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001292")]
		public ConnectionState CurrentState
		{
			[Token(Token = "0x6005B1D")]
			[Address(RVA = "0xA7F2", Offset = "0xA7F2", VA = "0xA7F2", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B1E")]
			[Address(RVA = "0xA7F3", Offset = "0xA7F3", VA = "0xA7F3")]
			protected set
			{
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x00010398 File Offset: 0x0000E598
		// (set) Token: 0x06005B20 RID: 23328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001293")]
		public bool IsRun
		{
			[Token(Token = "0x6005B1F")]
			[Address(RVA = "0xA7F4", Offset = "0xA7F4", VA = "0xA7F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B20")]
			[Address(RVA = "0xA7F5", Offset = "0xA7F5", VA = "0xA7F5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B21")]
		[Address(RVA = "0xA7F6", Offset = "0xA7F6", VA = "0xA7F6")]
		public AbstractConnection(IPacketParser parser, int handleCmdQueuePeriod)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Net_Connection_AbstractConnection___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a605c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___TypeInfo
		              );
		    DAT_ram_00a605c5 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_short__object___Clear
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___TypeInfo
		                          );
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_00,
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer____ctor__
		              );
		    System_Collections_Generic_Dictionary_short__object___get_Values
		              (*(undefined4 *)(param1 + 0x28),param2,param1_00,
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____set_Item__
		              );
		  }
		  else {
		    param1_00 = System_Collections_Generic_Dictionary_short__object___get_Count
		                          (*(undefined4 *)(param1 + 0x28),param2,
		                           Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                          );
		  }
		  func_ii_2946(param1_00,param3,param3,
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___set_Item__
		              );
		  return;
		}
		*/

		}

		// Token: 0x06005B22 RID: 23330
		[Token(Token = "0x6005B22")]
		public abstract void Push(SrvCommand command);

		// Token: 0x06005B23 RID: 23331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B23")]
		[Address(RVA = "0xA7F7", Offset = "0xA7F7", VA = "0xA7F7", Slot = "14")]
		public void AddServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		/* --- GHIDRA: AddServiceEventHandler ---
		void Core_Net_Connection_AbstractConnection__AddServiceEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a605c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		              );
		    DAT_ram_00a605c6 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_short__object___Clear
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_short__object___get_Count
		                      (*(undefined4 *)(param1 + 0x28),param2,
		                       Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                      );
		    iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                      (uVar2,param3,
		                       Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___ContainsKey__
		                      );
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_Dictionary_short__object___get_Count
		                        (*(undefined4 *)(param1 + 0x28),param2,
		                         Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                        );
		      System_Linq_Enumerable__First_KeyValuePair_object__object__
		                (uVar2,param3,
		                 Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___Remove__
		                );
		      uVar2 = System_Collections_Generic_Dictionary_short__object___get_Count
		                        (*(undefined4 *)(param1 + 0x28),param2,
		                         Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                        );
		      iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (uVar2,
		                         Method_System_Collections_Generic_Dictionary_Action_SrvAnswer___Action_SrvAnswer___get_Count__
		                        );
		      if (iVar1 == 0) {
		        System_Collections_Generic_Dictionary_short__object___OnDeserialization
		                  (*(undefined4 *)(param1 + 0x28),param2,
		                   Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____Remove__
		                  );
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B24")]
		[Address(RVA = "0xA7F8", Offset = "0xA7F8", VA = "0xA7F8", Slot = "15")]
		public void RemoveServiceEventHandler(short serviceId, Action<SrvAnswer> handler)
		{
		/* --- GHIDRA: RemoveServiceEventHandler ---
		undefined4
		Core_Net_Connection_AbstractConnection__RemoveServiceEventHandler
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
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
		  iVar1 = System_Collections_Generic_Dictionary_short__object___Clear
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_Dictionary_short__object___get_Count
		                      (*(undefined4 *)(param1 + 0x28),param2,
		                       Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____get_Item__
		                      );
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B25")]
		[Address(RVA = "0xA7F9", Offset = "0xA7F9", VA = "0xA7F9")]
		public Dictionary<Action<SrvAnswer>, Action<SrvAnswer>> GetEventHandlers(short serviceId)
		{
		/* --- GHIDRA: GetEventHandlers ---
		void Core_Net_Connection_AbstractConnection__GetEventHandlers(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a605c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Connection_AbstractConnection_HandlePacketCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_PacketParser_Packet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_IPacketParser_TypeInfo);
		    DAT_ram_00a605c8 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    *(undefined1 *)(param1 + 0x34) = 1;
		    piVar3 = *(int **)(param1 + 0x30);
		    uVar1 = 0;
		    param1_00 = unnamed_function_1417(System_Action_PacketParser_Packet__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Core_Net_Connection_AbstractConnection_HandlePacketCompleteEvent__,0);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Net_IPacketParser_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cb0d5e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Net_IPacketParser_TypeInfo,0);
		code_r0x81cb0d5e:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = *(int **)(param1 + 0x30);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Net_IPacketParser_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81cb0ddd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Net_IPacketParser_TypeInfo,4);
		code_r0x81cb0ddd:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B26")]
		[Address(RVA = "0xA7FA", Offset = "0xA7FA", VA = "0xA7FA", Slot = "19")]
		public virtual void Run()
		{
		/* --- GHIDRA: Run ---
		void Core_Net_Connection_AbstractConnection__Run(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a605c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Connection_AbstractConnection_HandlePacketCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_PacketParser_Packet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_IPacketParser_TypeInfo);
		    DAT_ram_00a605c9 = '\x01';
		  }
		  if ((char)param1[0xd] != '\0') {
		    uVar1 = 0;
		    *(undefined1 *)(param1 + 0xd) = 0;
		    param1_01 = (int *)param1[0xc];
		    param1_00 = unnamed_function_1417(System_Action_PacketParser_Packet__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Core_Net_Connection_AbstractConnection_HandlePacketCompleteEvent__,0);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Net_IPacketParser_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x81cb0ec6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Net_IPacketParser_TypeInfo,1);
		code_r0x81cb0ec6:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x168) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x16c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B27")]
		[Address(RVA = "0xA7FB", Offset = "0xA7FB", VA = "0xA7FB", Slot = "20")]
		public virtual void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Core_Net_Connection_AbstractConnection__Stop(int *param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int param3_00;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined2 local_a;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605ca == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IProtocolMessageFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13339);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7523);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11483);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14244);
		    DAT_ram_00a605ca = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param3_00 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(param3_00 + 0x178) * 4))
		                    (param1,param2,&local_4,*(undefined4 *)(param3_00 + 0x17c));
		  if (iVar3 == 0) {
		    if (*(int *)(param2 + 8) == 0) {
		      sVar1 = *(short *)(param2 + 0x18);
		      uVar2 = 0;
		      uVar7 = *(undefined4 *)(param2 + 0x1c);
		      piVar8 = (int *)param1[8];
		      iVar3 = *piVar8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Net_Connection_IProtocolMessageFactoriesRepository_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		            puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cb10a4;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Net_Connection_IProtocolMessageFactoriesRepository_TypeInfo
		                                    ,0);
		code_r0x81cb10a4:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,(int)sVar1,uVar7,&local_8,puVar4[1]);
		      if (iVar3 == 0) {
		        local_a = *(undefined2 *)(param2 + 0x18);
		        uVar7 = func_ii_1081(DAT_ram_00a6694c,&local_a);
		        uVar7 = func_ii_4419(StringLiteral_14244,uVar7,0);
		        local_10 = *(undefined4 *)(param2 + 0x1c);
		        uVar5 = func_ii_1081(DAT_ram_00a66958,&local_10);
		        uVar5 = func_ii_4419(StringLiteral_7523,uVar5,0);
		        local_14 = *(undefined4 *)(param2 + 0x20);
		        uVar6 = func_ii_1081(DAT_ram_00a66954,&local_14);
		        uVar6 = func_ii_4419(StringLiteral_13339,uVar6,0);
		        puVar4 = (uint *)System_Int32__ToString(StringLiteral_11483,uVar7,uVar5,uVar6,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(puVar4,0);
		      }
		      uVar7 = Core_Net_SrvAnswer__Parse(param2,local_8,puVar4);
		      iVar3 = param1[3];
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),uVar7,*(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		  }
		  else {
		    uVar7 = Core_Net_SrvAnswer__Create(param2,local_4,param3_00);
		    Core_Net_SrvCommand__get_Payload(local_4,uVar7,param3_00);
		    piVar8 = (int *)param1[9];
		    if (piVar8 != (int *)0x0) {
		      uVar2 = 0;
		      iVar3 = *piVar8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe8);
		            goto code_r0x81cb100d;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                    ,5);
		code_r0x81cb100d:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar7,puVar4[1]);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B28 RID: 23336
		[Token(Token = "0x6005B28")]
		public abstract void Rollback();

		// Token: 0x06005B29 RID: 23337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B29")]
		[Address(RVA = "0xA7FC", Offset = "0xA7FC", VA = "0xA7FC")]
		private void HandlePacketCompleteEvent(PacketParser.Packet packet)
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2A")]
		[Address(RVA = "0xA7FD", Offset = "0xA7FD", VA = "0xA7FD")]
		private void HandledEvent(SrvAnswer answer)
		{
		/* --- GHIDRA: HandledEvent ---
		undefined4
		Core_Net_Connection_AbstractConnection__HandledEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a605cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_IPacketParser_TypeInfo);
		    DAT_ram_00a605cb = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x30);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_IPacketParser_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81cb124c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Net_IPacketParser_TypeInfo,3);
		code_r0x81cb124c:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0xA7FE", Offset = "0xA7FE", VA = "0xA7FE")]
		protected IList<PacketParser.Packet> Receive(byte[] buffer)
		{
		/* --- GHIDRA: Receive ---
		void Core_Net_Connection_AbstractConnection__Receive(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a605cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo);
		    DAT_ram_00a605cc = '\x01';
		  }
		  param1_00 = (int *)param1[9];
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x184));
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81cb1315;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Core_Net_Monitor_Responseability_ILowResponseAbilityMonitor_TypeInfo
		                                  ,4);
		code_r0x81cb1315:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B2C")]
		[Address(RVA = "0xA7FF", Offset = "0xA7FF", VA = "0xA7FF", Slot = "22")]
		protected virtual void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		void Core_Net_Connection_AbstractConnection__HandleQueue(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a605cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    DAT_ram_00a605cd = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    if (param2 != (int *)0x0) {
		      if (((uint)*(byte *)(*param2 + 0xb8) <
		           (uint)*(byte *)(Core_Net_Connection_ConnectionState_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param2 + 100) +
		                   (uint)*(byte *)(Core_Net_Connection_ConnectionState_TypeInfo + 0xb8) * 4 + -4) !=
		          Core_Net_Connection_ConnectionState_TypeInfo)) {
		        System_Activator__CreateInstance(param2,Core_Net_Connection_ConnectionState_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005B2D RID: 23341
		[Token(Token = "0x6005B2D")]
		protected abstract bool TryRemoveAwaitCommand(PacketParser.Packet packet, out SrvCommand cmd);

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06005B2E RID: 23342
		[Token(Token = "0x17001294")]
		protected abstract IEnumerable<ISrvCommand> CommandsAwaitAnswer { [Token(Token = "0x6005B2E")] get; }

		// Token: 0x06005B2F RID: 23343
		[Token(Token = "0x6005B2F")]
		protected abstract bool Test();

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<short, Dictionary<Action<SrvAnswer>, Action<SrvAnswer>>> _eventHandlers;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x2C")]
		private ConnectionState _currentState;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x30")]
		protected readonly IPacketParser _parser;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x38")]
		public readonly int HandleCmdQueuePeriod;

		// Token: 0x02000EA5 RID: 3749
		[Token(Token = "0x2000EA5")]
		public enum ErrorCodes
		{
			// Token: 0x040031D2 RID: 12754
			[Token(Token = "0x40031D2")]
			COULD_NOT_RESOLVE_HOST = 11001,
			// Token: 0x040031D3 RID: 12755
			[Token(Token = "0x40031D3")]
			TIMEOUT_ERROR_CODE = 10060
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnStateChangedEvent ---
		void Core_Net_Connection_AbstractConnection__add_OnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    DAT_ram_00a605c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ConnectionState__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ConnectionState__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_OnStateChangedEvent ---
		void Core_Net_Connection_AbstractConnection__remove_OnStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvAnswer__TypeInfo);
		    DAT_ram_00a605c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SrvAnswer__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SrvAnswer__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_OnServerEventReceived ---
		void Core_Net_Connection_AbstractConnection__add_OnServerEventReceived
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a605c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvAnswer__TypeInfo);
		    DAT_ram_00a605c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SrvAnswer__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SrvAnswer__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: get_CurrentState ---
		void Core_Net_Connection_AbstractConnection__get_CurrentState
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a605c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_Connection_AbstractConnection__set_CurrentState_b__35_0__);
		    Mono_Security_ASN1__get_Item(&System_Threading_SendOrPostCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a605c3 = '\x01';
		  }
		  if (param2 != *(int *)(param1 + 0x2c)) {
		    *(int *)(param1 + 0x2c) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    piVar1 = (int *)**(undefined4 **)(Core_Net_SrvCommand_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(System_Threading_SendOrPostCallback_TypeInfo);
		    func_ii_13894(param1_00,param1,
		                  Method_Core_Net_Connection_AbstractConnection__set_CurrentState_b__35_0__,0);
		    iVar2 = *piVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (piVar1,param1_00,*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(iVar2 + 0xec));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsRun ---
		void Core_Net_Connection_AbstractConnection__set_IsRun
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a605c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____TypeInfo
		              );
		    DAT_ram_00a605c4 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0x200;
		  *(undefined8 *)(param1 + 0x14) = 0xffffffffffffffff;
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer____TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_HierarchyNode__TreeViewItemData_object____set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_short__Dictionary_Action_SrvAnswer___Action_SrvAnswer_____ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  iVar1 = unnamed_function_1417(Core_Net_Connection_ConnectionState_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  iVar2 = unnamed_function_1417(Core_Net_Connection_ConnectionState_ConnectionStateReason_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = 0;
		  *(int *)(iVar1 + 0xc) = iVar2;
		  *(int *)(param1 + 0x2c) = iVar1;
		  *(undefined4 *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x30) = param2;
		  return;
		}
		*/

}
