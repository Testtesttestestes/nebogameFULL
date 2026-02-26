using System;
using Il2CppDummyDll;

namespace Core.Net.Connection
{
	// Token: 0x02000EA6 RID: 3750
	[Token(Token = "0x2000EA6")]
	public class ConnectionState
	{
		// Token: 0x06005B31 RID: 23345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B31")]
		[Address(RVA = "0xA801", Offset = "0xA801", VA = "0xA801")]
		public ConnectionState(ConnectionState.ConnectionStates state)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Net_Connection_ConnectionState___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a605ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Connection_ConnectionState_ConnectionStates_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11586);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14644);
		    DAT_ram_00a605ce = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 8);
		  param2_00 = func_ii_1081(Core_Net_Connection_ConnectionState_ConnectionStates_TypeInfo,&local_4);
		  uVar1 = StringLiteral_14644;
		  piVar2 = *(int **)(param1 + 0xc);
		  param3 = StringLiteral_11586;
		  if (piVar2 != (int *)0x0) {
		    param3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd8) * 4))
		                       (piVar2,*(undefined4 *)(*piVar2 + 0xdc));
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar1,param2_00,param3,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B32")]
		[Address(RVA = "0xA802", Offset = "0xA802", VA = "0xA802", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x8")]
		public readonly ConnectionState.ConnectionStates State;

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0xC")]
		public ConnectionState.ConnectionStateReason Reason;

		// Token: 0x02000EA7 RID: 3751
		[Token(Token = "0x2000EA7")]
		public enum ConnectionStates
		{
			// Token: 0x040031D7 RID: 12759
			[Token(Token = "0x40031D7")]
			CLOSE,
			// Token: 0x040031D8 RID: 12760
			[Token(Token = "0x40031D8")]
			OPEN,
			// Token: 0x040031D9 RID: 12761
			[Token(Token = "0x40031D9")]
			PENNDING_OPEN
		}

		// Token: 0x02000EA8 RID: 3752
		[Token(Token = "0x2000EA8")]
		public class ConnectionStateReason
		{
			// Token: 0x06005B33 RID: 23347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B33")]
			[Address(RVA = "0xA803", Offset = "0xA803", VA = "0xA803")]
			public ConnectionStateReason(ConnectionState.ConnectionStateReason.ConnectionStateReasons reason = ConnectionState.ConnectionStateReason.ConnectionStateReasons.UNKNOWN)
			{
			}

			// Token: 0x06005B34 RID: 23348 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005B34")]
			[Address(RVA = "0xA804", Offset = "0xA804", VA = "0xA804", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040031DA RID: 12762
			[Token(Token = "0x40031DA")]
			[FieldOffset(Offset = "0x8")]
			public readonly ConnectionState.ConnectionStateReason.ConnectionStateReasons Reason;

			// Token: 0x040031DB RID: 12763
			[Token(Token = "0x40031DB")]
			[FieldOffset(Offset = "0xC")]
			public string Message;

			// Token: 0x040031DC RID: 12764
			[Token(Token = "0x40031DC")]
			[FieldOffset(Offset = "0x10")]
			public int ErrorCode;

			// Token: 0x02000EA9 RID: 3753
			[Token(Token = "0x2000EA9")]
			public enum ConnectionStateReasons
			{
				// Token: 0x040031DE RID: 12766
				[Token(Token = "0x40031DE")]
				UNKNOWN,
				// Token: 0x040031DF RID: 12767
				[Token(Token = "0x40031DF")]
				INTERNAL,
				// Token: 0x040031E0 RID: 12768
				[Token(Token = "0x40031E0")]
				CONNECT_PROCESS_TIMEOUT,
				// Token: 0x040031E1 RID: 12769
				[Token(Token = "0x40031E1")]
				MANUAL,
				// Token: 0x040031E2 RID: 12770
				[Token(Token = "0x40031E2")]
				SSL_AUTHENTICATION_FAIL,
				// Token: 0x040031E3 RID: 12771
				[Token(Token = "0x40031E3")]
				CONNECTION_LOST
			}
		}
	}
}
