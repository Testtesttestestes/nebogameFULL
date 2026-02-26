using System;
using Core.Gameplay.Managers.Configuration;
using Core.Net.Connection;
using Il2CppDummyDll;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001267 RID: 4711
	[Token(Token = "0x2001267")]
	public class ConnectionStateLogger
	{
		// Token: 0x06006FC9 RID: 28617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0xBA2A", Offset = "0xBA2A", VA = "0xBA2A")]
		private string Wrap(string value, ConnectionState state)
		{
		/* --- GHIDRA: Wrap ---
		void Core_Application_Managers_Connection_ConnectionStateLogger__Wrap
		               (undefined4 param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a877 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_IConnection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_241);
		    Mono_Security_ASN1__get_Item(&StringLiteral_263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_240);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4401);
		    DAT_ram_00a5a877 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  func_ii_2010(param1_00,StringLiteral_4401,0);
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81281597;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,0);
		code_r0x81281597:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  func_ii_13860(param1_00,uVar3,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar3 = func_ii_4419(StringLiteral_240,uVar3,0);
		  func_ii_2010(param1_00,uVar3,0);
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x81281657;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,4);
		code_r0x81281657:
		  local_8 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar3 = func_ii_4419(StringLiteral_241,uVar3,0);
		  func_ii_2010(param1_00,uVar3,0);
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81281703;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,2);
		code_r0x81281703:
		  local_c = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  uVar3 = func_ii_4419(StringLiteral_263,uVar3,0);
		  func_ii_2010(param1_00,uVar3,0);
		  uVar3 = System_String__CreateString(0,0x2b,0x50,0);
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x812817bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,6);
		code_r0x812817bc:
		  (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x81281870;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,6);
		code_r0x81281870:
		  (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar1 = 0;
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  uVar3 = System_String__CreateString(0,0x2b,0x50,0);
		  iVar4 = *param3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Net_Connection_IConnection_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x81281904;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Net_Connection_IConnection_TypeInfo,6);
		code_r0x81281904:
		  (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0xBA2B", Offset = "0xBA2B", VA = "0xBA2B")]
		public void Log(ConfigRecord config, IConnection connection)
		{
		/* --- GHIDRA: Log ---
		void Core_Application_Managers_Connection_ConnectionStateLogger__Log
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a879 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a879 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log ---
		void Core_Application_Managers_Connection_ConnectionStateLogger__Log
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a879 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a879 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: Log ---
		void Core_Application_Managers_Connection_ConnectionStateLogger__Log
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a879 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a879 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0xBA2C", Offset = "0xBA2C", VA = "0xBA2C")]
		public void Log(ConnectionState state, IConnection connection)
		{
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0xBA2D", Offset = "0xBA2D", VA = "0xBA2D")]
		public void Log(string value, ConnectionState state)
		{
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0xBA2E", Offset = "0xBA2E", VA = "0xBA2E")]
		public ConnectionStateLogger()
		{
		}

		// Token: 0x04003A62 RID: 14946
		[Token(Token = "0x4003A62")]
		public const string IDLE_COLOR = "teal";

		// Token: 0x04003A63 RID: 14947
		[Token(Token = "0x4003A63")]
		public const string WARNING_COLOR = "purple";
	}
}
