using System;
using Core.Events;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CE RID: 4814
	[Token(Token = "0x20012CE")]
	public class DebugAnalyticsListenerProxy : AbstractAnalyticsListener
	{
		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001731")]
		protected override string Theme
		{
			[Token(Token = "0x6007273")]
			[Address(RVA = "0xBC7C", Offset = "0xBC7C", VA = "0xBC7C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001732")]
		public override EventBus EventBus
		{
			[Token(Token = "0x6007274")]
			[Address(RVA = "0xBC7D", Offset = "0xBC7D", VA = "0xBC7D", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007275")]
		[Address(RVA = "0xBC7E", Offset = "0xBC7E", VA = "0xBC7E", Slot = "8")]
		public override void AddService(IAnalyticsService service)
		{
		/* --- GHIDRA: AddService ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__AddService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar1 = 0;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__AddService(param1,param2,0);
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x108) * 4))
		                (piVar3,param2,*(undefined4 *)(iVar4 + 0x10c));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007276")]
		[Address(RVA = "0xBC7F", Offset = "0xBC7F", VA = "0xBC7F", Slot = "9")]
		public override void RemoveService(IAnalyticsService service)
		{
		/* --- GHIDRA: RemoveService ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__RemoveService
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))(piVar3,*(undefined4 *)(iVar4 + 0x114));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007277")]
		[Address(RVA = "0xBC80", Offset = "0xBC80", VA = "0xBC80", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      func_ii_8818(*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007278")]
		[Address(RVA = "0xBC81", Offset = "0xBC81", VA = "0xBC81", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__Deinit(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a595c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Listeners_AbstractAnalyticsListener___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_TypeInfo);
		    DAT_ram_00a595c3 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Core_Analytics_Listeners_AbstractAnalyticsListener___TypeInfo,1);
		  param1_00 = unnamed_function_1417
		                        (
		                        Core_Analytics_Listeners_DebugListeners_Debug107447AnalyticsListener_TypeInfo
		                        );
		  if (DAT_ram_00a5966a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a5966a = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1_00 + 0x10) = uVar2;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1_00,0);
		  iVar3 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar3 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = param1_00;
		  *(int **)(param1 + 0x10) = piVar1;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__GetResourceAnalyticsName(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007279")]
		[Address(RVA = "0xBC82", Offset = "0xBC82", VA = "0xBC82")]
		public DebugAnalyticsListenerProxy()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_DebugAnalyticsListenerProxy___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22691);
		    DAT_ram_00a595c4 = '\x01';
		  }
		  return StringLiteral_22691;
		}
		*/

		}

		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		[FieldOffset(Offset = "0x10")]
		private readonly AbstractAnalyticsListener[] _listeners;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__get_Theme
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  *(undefined4 *)(param1 + 0xc) = param2;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf8) * 4))
		                (piVar3,param2,*(undefined4 *)(iVar4 + 0xfc));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_EventBus ---
		void Core_Analytics_Listeners_DebugAnalyticsListenerProxy__set_EventBus
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar1 = 0;
		  Core_Analytics_Listeners_AbstractAnalyticsListener__set_EventBus(param1,param2,0);
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                (piVar3,param2,*(undefined4 *)(iVar4 + 0x104));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

}
