using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Il2CppDummyDll;
using Protocol.Auth;

namespace ServicesNamespace
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public class AuthService : AbstractService
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x17000091")]
		public override short ServiceId
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x5817", Offset = "0x5817", VA = "0x5817", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000015")]
		public event Action<ProtoBanStatusChangedEvt> BanStatusChangedEvent
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x5818", Offset = "0x5818", VA = "0x5818")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x5819", Offset = "0x5819", VA = "0x5819")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x581A", Offset = "0x581A", VA = "0x581A", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x581B", Offset = "0x581B", VA = "0x581B")]
		public AuthService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_AuthService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62883 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		    DAT_ram_00a62883 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBanStatusChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBanStatusChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: add_BanStatusChangedEvent ---
		void ServicesNamespace_AuthService__add_BanStatusChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62884 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		    DAT_ram_00a62884 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoBanStatusChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoBanStatusChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
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


		/* --- GHIDRA: remove_BanStatusChangedEvent ---
		void ServicesNamespace_AuthService__remove_BanStatusChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a62885 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_AuthEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth_ProtoBanStatusChangedEvt_TypeInfo);
		    DAT_ram_00a62885 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_AuthEvents___);
		  if ((iVar1 == 2) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) && (Protocol_Auth_ProtoBanStatusChangedEvt_TypeInfo != *param1_00)
		       ) {
		      System_Activator__CreateInstance(param1_00,Protocol_Auth_ProtoBanStatusChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
