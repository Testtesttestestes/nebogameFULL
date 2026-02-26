using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using Protocol.System;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001264 RID: 4708
	[Token(Token = "0x2001264")]
	public class ConnectionManager : IAppManager, IBaseManager, IConnectionManage
	{
		// Token: 0x140002F5 RID: 757
		// (add) Token: 0x06006F9E RID: 28574 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F9F RID: 28575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F5")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F9E")]
			[Address(RVA = "0xB9FF", Offset = "0xB9FF", VA = "0xB9FF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F9F")]
			[Address(RVA = "0xBA00", Offset = "0xBA00", VA = "0xBA00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F6 RID: 758
		// (add) Token: 0x06006FA0 RID: 28576 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006FA1 RID: 28577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F6")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006FA0")]
			[Address(RVA = "0xBA01", Offset = "0xBA01", VA = "0xBA01", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006FA1")]
			[Address(RVA = "0xBA02", Offset = "0xBA02", VA = "0xBA02", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C6")]
		public string Name
		{
			[Token(Token = "0x6006FA2")]
			[Address(RVA = "0xBA03", Offset = "0xBA03", VA = "0xBA03", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x000144F0 File Offset: 0x000126F0
		// (set) Token: 0x06006FA4 RID: 28580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C7")]
		private int ConnectionOpenedCount
		{
			[Token(Token = "0x6006FA3")]
			[Address(RVA = "0xBA04", Offset = "0xBA04", VA = "0xBA04")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006FA4")]
			[Address(RVA = "0xBA05", Offset = "0xBA05", VA = "0xBA05")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C8")]
		public IPing Ping
		{
			[Token(Token = "0x6006FA5")]
			[Address(RVA = "0xBA06", Offset = "0xBA06", VA = "0xBA06")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C9")]
		public IApp App
		{
			[Token(Token = "0x6006FA6")]
			[Address(RVA = "0xBA07", Offset = "0xBA07", VA = "0xBA07")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FA7")]
			[Address(RVA = "0xBA08", Offset = "0xBA08", VA = "0xBA08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CA")]
		private IConnection Connection
		{
			[Token(Token = "0x6006FA8")]
			[Address(RVA = "0xBA09", Offset = "0xBA09", VA = "0xBA09")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FA9")]
			[Address(RVA = "0xBA0A", Offset = "0xBA0A", VA = "0xBA0A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CB")]
		public IRecoveryConnection RecoveryConnection
		{
			[Token(Token = "0x6006FAA")]
			[Address(RVA = "0xBA0B", Offset = "0xBA0B", VA = "0xBA0B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAB")]
			[Address(RVA = "0xBA0C", Offset = "0xBA0C", VA = "0xBA0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CC")]
		public ISystemDisconnectResolver DisconnectResolver
		{
			[Token(Token = "0x6006FAC")]
			[Address(RVA = "0xBA0D", Offset = "0xBA0D", VA = "0xBA0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAD")]
			[Address(RVA = "0xBA0E", Offset = "0xBA0E", VA = "0xBA0E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CD")]
		public LowResponseAbilityMonitor LatencyMonitor
		{
			[Token(Token = "0x6006FAE")]
			[Address(RVA = "0xBA0F", Offset = "0xBA0F", VA = "0xBA0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAF")]
			[Address(RVA = "0xBA10", Offset = "0xBA10", VA = "0xBA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0xBA11", Offset = "0xBA11", VA = "0xBA11")]
		public ConnectionManager(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Connection_ConnectionManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a86b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionStateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleLatencyMonitorTestRunEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a86b = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_double__TypeInfo);
		  System_Action_DictionaryEntry___Invoke
		            (uVar2,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleLatencyMonitorTestRunEvent__
		             ,0);
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__add_TestRunEvent(param1_00,uVar2,0);
		  piVar4 = *(int **)(param1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_ConnectionState__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionStateEvent__
		             ,0);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x100);
		        goto code_r0x81280a86;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Net_Connection_IConnection_TypeInfo,8);
		code_r0x81280a86:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(*(int *)(param1 + 0x30) + 0x18);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81280b08;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x81280b08:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__set_Analysis
		            (*(undefined4 *)(param1 + 0x30),0);
		  iVar6 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a5a861 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5a861 = '\x01';
		  }
		  piVar4 = *(int **)(iVar6 + 0x24);
		  if (piVar4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81280bc1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x81280bc1:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  }
		  *(undefined4 *)(iVar6 + 0x18) = 0;
		  *(undefined4 *)(iVar6 + 0x24) = 0;
		  *(undefined4 *)(iVar6 + 8) = 0;
		  *(undefined8 *)(iVar6 + 0x10) = 0;
		  iVar6 = *(int *)(param1 + 0x1c);
		  uVar1 = 0;
		  Core_Application_Managers_Connection_Ping__Run(iVar6,0);
		  *(undefined4 *)(iVar6 + 0x10) = 0;
		  *(undefined8 *)(iVar6 + 8) = 0;
		  *(undefined1 *)(iVar6 + 0x14) = 1;
		  piVar4 = *(int **)(param1 + 0x28);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81280c84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x81280c84:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined8 *)(param1 + 0x2c) = 0;
		  *(undefined8 *)(param1 + 0x24) = 0;
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(undefined8 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0xBA12", Offset = "0xBA12", VA = "0xBA12", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Application_Managers_Connection_ConnectionManager__Deinit(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  uint uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar9;
		  int iVar10;
		  undefined4 uVar11;
		  int *param1_02;
		  int *local_4;
		  
		  if (DAT_ram_00a5a86c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ConnectionState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_Configuration_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_ConnectionInformer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionStateEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleLatencyMonitorTestRunEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_ConnectionStateLogger_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Net_Monitor_Responseability_LowResponseAbilityMonitor_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_Analysis_MedianAnalysis_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_Ping_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ProtocolMessageFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1713);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24445);
		    DAT_ram_00a5a86c = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar9 = *(int **)(param1 + 0x20);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x110);
		        goto code_r0x81280e5f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,10);
		code_r0x81280e5f:
		  uVar3 = CONCAT44(in_register_20000014,puVar4[1]);
		  iVar10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar2 = 0;
		  piVar9 = *(int **)(iVar10 + 0x10);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81280ee4;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,0);
		code_r0x81280ee4:
		  uVar2 = 0;
		  iVar10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,CONCAT44(uVar5,puVar4[1]));
		  uVar5 = Core_Net_Connection_SSLConnection___c__DisplayClass15_0___Send_b__0(0);
		  *(undefined4 *)(param1 + 0x24) = uVar5;
		  iVar6 = unnamed_function_1417(Core_Application_Managers_Connection_Ping_TypeInfo);
		  *(undefined4 *)(iVar6 + 0x10) = uVar5;
		  *(int *)(iVar6 + 8) = iVar10;
		  *(int *)(param1 + 0x1c) = iVar6;
		  iVar6 = unnamed_function_1417(Core_Net_Monitor_Responseability_Configuration_TypeInfo);
		  uVar7 = unnamed_function_1417(object_TypeInfo);
		  uVar8 = System_Threading_SynchronizationContext__SetSynchronizationContext(0);
		  uVar11 = *(undefined4 *)(iVar10 + 0xc);
		  uVar5 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar5,uVar11,0);
		  uVar5 = func_ii_8749(uVar5,0);
		  uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_24445,uVar5,StringLiteral_1713,0);
		  uVar11 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar11,uVar5,0);
		  param1_00 = unnamed_function_1417
		                        (Core_Net_Monitor_Responseability_FrequencyLimitHttpNetTestLauncher_TypeInfo
		                        );
		  uVar5 = 0;
		  Core_Net_Monitor_Responseability_Configuration___ctor(param1_00,2000,uVar11,iVar6,uVar7,0);
		  uVar11 = unnamed_function_1417(Core_Net_Monitor_Responseability_Analysis_MedianAnalysis_TypeInfo);
		  Core_Net_Monitor_Responseability_Analysis_MedianAnalysis__Dispose(uVar11,iVar6,0);
		  bVar1 = *(byte *)(iVar6 + 0x1c);
		  param1_01 = unnamed_function_1417
		                        (Core_Net_Monitor_Responseability_LowResponseAbilityMonitor_TypeInfo);
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__Dispose
		            (param1_01,uVar8,uVar7,param1_00,uVar11,iVar6,(uint)bVar1,0);
		  *(undefined4 *)(param1 + 0x30) = param1_01;
		  uVar7 = Core_Net_Connection_SSLConnection___c__DisplayClass15_0___Send_b__0(0);
		  uVar8 = System_Threading_SynchronizationContext__SetSynchronizationContext(0);
		  uVar11 = unnamed_function_1417(Core_ProtocolMessageFactoriesRepository_TypeInfo);
		  Core_ProtocolMessageFactoriesRepository__TryGetFactory(uVar11,0);
		  Core_Net_Connection_ServerConnection__get_CurrentState
		            (uVar7,uVar8,uVar11,*(undefined4 *)(param1 + 0x30),0);
		  piVar9 = *(int **)(param1 + 0x24);
		  uVar7 = unnamed_function_1417(System_Action_ConnectionState__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar7,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionStateEvent__
		             ,0);
		  iVar6 = *piVar9;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8))
		      {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xf8);
		        goto code_r0x812810c2;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Net_Connection_IConnection_TypeInfo,7);
		code_r0x812810c2:
		  uVar3 = CONCAT44(uVar5,uVar7);
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3,puVar4[1]);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar8 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = 0;
		  uVar7 = unnamed_function_1417(System_Action_double__TypeInfo);
		  System_Action_DictionaryEntry___Invoke
		            (uVar7,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleLatencyMonitorTestRunEvent__
		             ,0);
		  Core_Net_Monitor_Responseability_LowResponseAbilityMonitor__remove_ResponseTimeExceededEvent
		            (uVar8,uVar7,0);
		  piVar9 = *(int **)(param1 + 0x20);
		  iVar6 = *piVar9;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8128116f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,3);
		code_r0x8128116f:
		  uVar3 = CONCAT44(uVar5,puVar4[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar7 = *(undefined4 *)(iVar6 + 0x34);
		  uVar8 = *(undefined4 *)(param1 + 0x2c);
		  uVar11 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = 0;
		  iVar6 = unnamed_function_1417(Core_Application_Managers_Connection_ConnectionInformer_TypeInfo);
		  *(undefined4 *)(iVar6 + 0x20) = 0x7fc00000;
		  *(undefined4 *)(iVar6 + 0x14) = uVar11;
		  *(undefined4 *)(iVar6 + 0x10) = uVar7;
		  *(undefined4 *)(iVar6 + 0xc) = 0x41000000;
		  *(undefined4 *)(iVar6 + 8) = uVar8;
		  *(int *)(param1 + 0x14) = iVar6;
		  uVar7 = unnamed_function_1417(Core_Application_Managers_Connection_ConnectionStateLogger_TypeInfo)
		  ;
		  *(undefined4 *)(param1 + 0x18) = uVar7;
		  piVar9 = *(int **)(param1 + 0x20);
		  iVar6 = *piVar9;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x81281252;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,10);
		code_r0x81281252:
		  uVar3 = CONCAT44(uVar5,puVar4[1]);
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar2 = 0;
		  piVar9 = *(int **)(iVar6 + 0x10);
		  iVar6 = *piVar9;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x812812d7;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,5);
		code_r0x812812d7:
		  uVar3 = CONCAT44(uVar5,&local_4);
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3,puVar4[1]);
		  piVar9 = local_4;
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  param1_02 = *(int **)(param1 + 0x24);
		  if (iVar6 == 0) {
		    uVar8 = *(undefined4 *)(iVar10 + 0xc);
		    uVar2 = 0;
		    uVar7 = unnamed_function_1417(System_Uri_TypeInfo);
		    UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar7,uVar8,0);
		    iVar6 = *param1_02;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)
		           ) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81281478;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_02,Core_Net_Connection_IConnection_TypeInfo,1);
		  }
		  else {
		    uVar2 = 0;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x8128136e;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,2);
		code_r0x8128136e:
		    uVar3 = CONCAT44(uVar5,puVar4[1]);
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar3);
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar7 = *(undefined4 *)(iVar6 + 8);
		    uVar2 = 0;
		    iVar6 = *param1_02;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)
		           ) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x81281478;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_02,Core_Net_Connection_IConnection_TypeInfo,1);
		  }
		code_r0x81281478:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_02,CONCAT44(uVar5,uVar7),puVar4[1]);
		  Core_Application_Managers_Connection_ConnectionStateLogger__Wrap
		            (puVar4,iVar10,*(undefined4 *)(param1 + 0x24),puVar4);
		  Core_Application_Managers_Connection_ConnectionManager__ReConnect(param1,puVar4);
		  return;
		}
		*/

		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0xBA13", Offset = "0xBA13", VA = "0xBA13", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_Connection_ConnectionManager__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a86d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a86d = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x81281b2e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,6);
		code_r0x81281b2e:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar4 != 0) {
		      *(undefined4 *)(*(int *)(param1 + 0x34) + 0xc) = 0;
		    }
		  }
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x81281bbb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Net_Connection_IConnection_TypeInfo,1);
		code_r0x81281bbb:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param2,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  if (DAT_ram_00a5a874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		              );
		    DAT_ram_00a5a874 = '\x01';
		  }
		  iVar4 = unnamed_function_1417
		                    (
		                    Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		                    );
		  *(undefined4 *)(iVar4 + 0x14) = param3;
		  *(int *)(iVar4 + 0x10) = param1;
		  *(undefined4 *)(iVar4 + 8) = 0;
		  Utils_CoroutineSource__GetMono(iVar4,0);
		  *(int *)(*(int *)(param1 + 0x34) + 0xc) = *(int *)(*(int *)(param1 + 0x34) + 0xc) + 1;
		  return;
		}
		*/

		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB3")]
		[Address(RVA = "0xBA14", Offset = "0xBA14", VA = "0xBA14", Slot = "13")]
		public void ReConnect(Uri uri, Action callback)
		{
		/* --- GHIDRA: ReConnect ---
		void Core_Application_Managers_Connection_ConnectionManager__ReConnect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  *(undefined4 *)(param1 + 0x10) = 0;
		  if (DAT_ram_00a5a874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		              );
		    DAT_ram_00a5a874 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		                        );
		  *(undefined4 *)(param1_00 + 0x14) = param2;
		  *(int *)(param1_00 + 0x10) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: ReConnect ---
		void Core_Application_Managers_Connection_ConnectionManager__ReConnect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  *(undefined4 *)(param1 + 0x10) = 0;
		  if (DAT_ram_00a5a874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		              );
		    DAT_ram_00a5a874 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		                        );
		  *(undefined4 *)(param1_00 + 0x14) = param2;
		  *(int *)(param1_00 + 0x10) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  Utils_CoroutineSource__GetMono(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0xBA15", Offset = "0xBA15", VA = "0xBA15", Slot = "12")]
		public void ReConnect(Action callback)
		{
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0xBA16", Offset = "0xBA16", VA = "0xBA16", Slot = "11")]
		public void RunConnect()
		{
		/* --- GHIDRA: RunConnect ---
		void Core_Application_Managers_Connection_ConnectionManager__RunConnect
		               (int param1,double param2,undefined4 param3)
		
		{
		  uint uVar1;
		  double dVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  dVar2 = param2;
		  if (DAT_ram_00a5a86f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_AppScope_LatencyMonitorArgs_TypeInfo);
		    DAT_ram_00a5a86f = '\x01';
		  }
		  uVar4 = (undefined4)((ulonglong)dVar2 >> 0x20);
		  param1_00 = *(int **)(param1 + 0x20);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		        goto code_r0x81281e20;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,8);
		code_r0x81281e20:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(uVar4,puVar3[1]));
		  iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x1c) + 0x2c);
		  if (iVar5 != 0) {
		    uVar4 = unnamed_function_1417(Core_Events_Scopes_AppScope_LatencyMonitorArgs_TypeInfo);
		    Core_Events_Scopes_AppScope_LoadingEventArgs___ctor(uVar4,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),uVar4,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0xBA17", Offset = "0xBA17", VA = "0xBA17")]
		private void HandleLatencyMonitorTestRunEvent(double avgLatency)
		{
		/* --- GHIDRA: HandleLatencyMonitorTestRunEvent ---
		void Core_Application_Managers_Connection_ConnectionManager__HandleLatencyMonitorTestRunEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a870 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DisconnectCode__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleServerReadyToStopEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ILoginProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SystemService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13250);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13249);
		    DAT_ram_00a5a870 = '\x01';
		  }
		  Core_Application_Managers_Connection_ConnectionStateLogger__Log
		            (param2,param2,*(undefined4 *)(param1 + 0x24),param2);
		  Core_Application_Managers_Connection_ConnectionInformer___ctor
		            (*(undefined4 *)(param1 + 0x14),param2,param2);
		  iVar5 = *(int *)(param2 + 8);
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_SystemService___);
		    uVar3 = unnamed_function_1417(System_Action_DisconnectCode__TypeInfo);
		    System_Action_int___Invoke
		              (uVar3,param1,
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionClosedEvent__
		               ,0);
		    ServicesNamespace_SystemService__add_ConnectionClosedEvent(uVar2,uVar3,0);
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_SystemService___);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Core_Application_Managers_Connection_ConnectionManager_HandleServerReadyToStopEvent__
		               ,0);
		    ServicesNamespace_SystemService__add_ServerReadyToStopEvent(uVar2,uVar3,0);
		    uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
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
		    iVar5 = Core_Net_SrvCommand_TypeInfo;
		    *(undefined4 *)(*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 8) = uVar2;
		    Core_Application_Managers_Connection_Ping__Run(*(undefined4 *)(param1 + 0x1c),iVar5);
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x2c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x812825d4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,
		                                  Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo
		                                  ,2);
		code_r0x812825d4:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,param1,puVar4[1]);
		    return;
		  }
		  if (iVar5 != 1) {
		    if (iVar5 != 2) {
		      return;
		    }
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x2c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x81281f9f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,
		                                  Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo
		                                  ,1);
		code_r0x81281f9f:
		    local_8 = 0;
		    local_10 = 0;
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar6,&local_10,puVar4[1]);
		    return;
		  }
		  iVar5 = *(int *)(param1 + 0x10);
		  puVar4 = (uint *)(iVar5 + 1);
		  *(uint **)(param1 + 0x10) = puVar4;
		  if (iVar5 == 0) {
		    iVar5 = *(int *)(param1 + 8);
		    if (iVar5 == 0) {
		      puVar4 = (uint *)0x0;
		      goto code_r0x812823cd;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		    puVar4 = *(uint **)(param1 + 0x10);
		  }
		  if (1 < (int)puVar4) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x20);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		          goto code_r0x81282080;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x14);
		code_r0x81282080:
		    iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    if (iVar5 != 0) {
		      uVar1 = 0;
		      piVar6 = *(int **)(param1 + 0x20);
		      iVar5 = *piVar6;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		            goto code_r0x81282106;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x14);
		code_r0x81282106:
		      iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      if (0 < *(int *)(*(int *)(iVar5 + 0x14) + 0x28)) {
		        uVar1 = 0;
		        piVar6 = *(int **)(param1 + 0x28);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81282194;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,
		                                      Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo
		                                      ,0);
		code_r0x81282194:
		        piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		        uVar1 = 0;
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_Managers_ILoginProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81282218;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_ILoginProvider_TypeInfo,0);
		code_r0x81282218:
		        uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		        local_8 = CONCAT44(local_8._4_4_,uVar2);
		        uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		        uVar2 = func_ii_4419(StringLiteral_13250,uVar2,0);
		        if (DAT_ram_00a5a879 == '\0') {
		          Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		          DAT_ram_00a5a879 = '\x01';
		        }
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        uVar1 = 0;
		        System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		        piVar6 = *(int **)(param1 + 0x20);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0)
		              ;
		              goto code_r0x812822fb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x812822fb:
		        uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(StringLiteral_13249,1,0,1,0,0,0,0);
		        Core_Application_App__get_ToastController(uVar2,1,uVar3,0);
		        piVar6 = *(int **)(param1 + 0x28);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100
		                               );
		              goto code_r0x812823bb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,
		                                      Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo
		                                      ,8);
		code_r0x812823bb:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      }
		    }
		  }
		code_r0x812823cd:
		  Core_Application_Managers_Connection_Ping__PingCoroutine(*(undefined4 *)(param1 + 0x1c),puVar4);
		  *(undefined4 *)(*(int *)(param1 + 0x34) + 8) = 0;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SystemService___);
		  uVar3 = unnamed_function_1417(System_Action_DisconnectCode__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleConnectionClosedEvent__
		             ,0);
		  ServicesNamespace_SystemService__get_ServiceId(uVar2,uVar3,0);
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SystemService___);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Application_Managers_Connection_ConnectionManager_HandleServerReadyToStopEvent__
		             ,0);
		  ServicesNamespace_SystemService__remove_ConnectionClosedEvent(uVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB7")]
		[Address(RVA = "0xBA18", Offset = "0xBA18", VA = "0xBA18")]
		private void HandleConnectionStateEvent(ConnectionState state)
		{
		/* --- GHIDRA: HandleConnectionStateEvent ---
		void Core_Application_Managers_Connection_ConnectionManager__HandleConnectionStateEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a871 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_System_DisconnectCode_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13134);
		    DAT_ram_00a5a871 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x2c);
		  local_10 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor
		            (&local_10,param2,Method_System_Nullable_DisconnectCode___ctor__);
		  local_8 = local_10;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x81282a88;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,
		                                Core_Application_Managers_Connection_ISystemDisconnectResolver_TypeInfo
		                                ,1);
		code_r0x81282a88:
		  local_18 = local_8;
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar3,&local_18,puVar1[1]);
		  local_8 = CONCAT44(local_8._4_4_,param2);
		  uVar5 = 0;
		  uVar2 = func_ii_1081(Protocol_System_DisconnectCode_TypeInfo,&local_8);
		  uVar2 = func_ii_4419(StringLiteral_13134,uVar2,0);
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8))
		      {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x81282b4f;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Net_Connection_IConnection_TypeInfo,6);
		code_r0x81282b4f:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  if (DAT_ram_00a5a879 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a879 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  uVar5 = 0;
		  Core_Application_Managers_Connection_Ping__Run(*(undefined4 *)(param1 + 0x1c),0);
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8))
		      {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x128);
		        goto code_r0x81282c19;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Net_Connection_IConnection_TypeInfo,0xd);
		code_r0x81282c19:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xBA19", Offset = "0xBA19", VA = "0xBA19")]
		private void HandleConnectionClosedEvent(DisconnectCode code)
		{
		/* --- GHIDRA: HandleConnectionClosedEvent ---
		void Core_Application_Managers_Connection_ConnectionManager__HandleConnectionClosedEvent
		               (int param1,undefined4 param2)
		
		{
		  Core_Application_Managers_Connection_ConnectionInformer__HandleResponseTimeExceededEvent
		            (*(undefined4 *)(param1 + 0x14),param1);
		  return;
		}
		*/

		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0xBA1A", Offset = "0xBA1A", VA = "0xBA1A")]
		private void HandleServerReadyToStopEvent()
		{
		/* --- GHIDRA: HandleServerReadyToStopEvent ---
		int Core_Application_Managers_Connection_ConnectionManager__HandleServerReadyToStopEvent
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a872 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Connection_ConnectionManager__ConnectCoroutine_d__49_TypeInfo
		              );
		    DAT_ram_00a5a872 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Application_Managers_Connection_ConnectionManager__ConnectCoroutine_d__49_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0xBA1B", Offset = "0xBA1B", VA = "0xBA1B")]
		private IEnumerator ConnectCoroutine(float delay)
		{
		/* --- GHIDRA: ConnectCoroutine ---
		void Core_Application_Managers_Connection_ConnectionManager__ConnectCoroutine
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a873 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2570);
		    DAT_ram_00a5a873 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar1 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_2570,0);
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x128);
		        goto code_r0x81282d0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Net_Connection_IConnection_TypeInfo,0xd);
		code_r0x81282d0b:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x24);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x81282d8e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Net_Connection_IConnection_TypeInfo,6);
		code_r0x81282d8e:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Core_Application_Managers_Connection_ConnectionStateLogger__Log
		            (puVar2,param2_00,*(undefined4 *)(param1 + 0x24),puVar2);
		  Core_Application_Managers_Connection_ConnectionManager___ctor(param1,puVar2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0xBA1C", Offset = "0xBA1C", VA = "0xBA1C")]
		private void InstanceOnAppQuitEvent()
		{
		/* --- GHIDRA: InstanceOnAppQuitEvent ---
		int Core_Application_Managers_Connection_ConnectionManager__InstanceOnAppQuitEvent
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		              );
		    DAT_ram_00a5a874 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Application_Managers_Connection_ConnectionManager__Internal_ReConnect_d__51_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FBC")]
		[Address(RVA = "0xBA1D", Offset = "0xBA1D", VA = "0xBA1D")]
		private IEnumerator Internal_ReConnect(Action completeCallback)
		{
			return null;
		}

		// Token: 0x04003A4E RID: 14926
		[Token(Token = "0x4003A4E")]
		public const int FIRST_TIME_CONNECTION_COUNT = 1;

		// Token: 0x04003A50 RID: 14928
		[Token(Token = "0x4003A50")]
		[FieldOffset(Offset = "0x14")]
		private ConnectionInformer _informer;

		// Token: 0x04003A51 RID: 14929
		[Token(Token = "0x4003A51")]
		[FieldOffset(Offset = "0x18")]
		private ConnectionStateLogger _logger;

		// Token: 0x04003A52 RID: 14930
		[Token(Token = "0x4003A52")]
		[FieldOffset(Offset = "0x1C")]
		private Ping _ping;

		// Token: 0x04003A58 RID: 14936
		[Token(Token = "0x4003A58")]
		[FieldOffset(Offset = "0x34")]
		public ServerConnectionDelay ConnectionDelay;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_Connection_ConnectionManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a866 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a866 = '\x01';
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
		void Core_Application_Managers_Connection_ConnectionManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a867 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a867 = '\x01';
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
		void Core_Application_Managers_Connection_ConnectionManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a868 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a868 = '\x01';
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
		undefined4
		Core_Application_Managers_Connection_ConnectionManager__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a869 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5700);
		    DAT_ram_00a5a869 = '\x01';
		  }
		  return StringLiteral_5700;
		}
		*/


		/* --- GHIDRA: set_LatencyMonitor ---
		void Core_Application_Managers_Connection_ConnectionManager__set_LatencyMonitor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a86a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_DefaultSystemDisconnectResolver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_RecoveryConnectionHelper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Connection_ServerConnectionDelay_TypeInfo);
		    DAT_ram_00a5a86a = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Application_Managers_Connection_ServerConnectionDelay_TypeInfo)
		  ;
		  *(undefined4 *)(iVar2 + 0x10) = 0;
		  *(undefined8 *)(iVar2 + 8) = 0;
		  *(int *)(param1 + 0x34) = iVar2;
		  *(int **)(param1 + 0x20) = param2;
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x128);
		        goto code_r0x812784de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Application_IApp_TypeInfo,0xd);
		code_r0x812784de:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  param1_00 = unnamed_function_1417(Core_Gameplay_RecoveryConnectionHelper_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar4,0);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  param1_01 = *(int **)(param1 + 0x20);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x168);
		        goto code_r0x8127857e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,0x15);
		code_r0x8127857e:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = unnamed_function_1417(Core_Application_Managers_DefaultSystemDisconnectResolver_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  *(int *)(param1 + 0x2c) = iVar2;
		  return;
		}
		*/

}
