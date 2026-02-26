using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using Protocol.Chat;
using Protocol.Dic;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	public class ChatRoomData : IDisposable
	{
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D78")]
		public RoomKey RoomKey
		{
			[Token(Token = "0x6004457")]
			[Address(RVA = "0x9307", Offset = "0x9307", VA = "0x9307")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x0000CE28 File Offset: 0x0000B028
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D79")]
		public int NotViewedMessagesCount
		{
			[Token(Token = "0x6004458")]
			[Address(RVA = "0x9308", Offset = "0x9308", VA = "0x9308")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004459")]
			[Address(RVA = "0x9309", Offset = "0x9309", VA = "0x9309")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x930A", Offset = "0x930A", VA = "0x930A", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7A")]
		public RoomRight Rights
		{
			[Token(Token = "0x600445B")]
			[Address(RVA = "0x930B", Offset = "0x930B", VA = "0x930B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600445C")]
			[Address(RVA = "0x930C", Offset = "0x930C", VA = "0x930C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x0000CE40 File Offset: 0x0000B040
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7B")]
		public bool IsReady
		{
			[Token(Token = "0x600445D")]
			[Address(RVA = "0x930D", Offset = "0x930D", VA = "0x930D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600445E")]
			[Address(RVA = "0x930E", Offset = "0x930E", VA = "0x930E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7C")]
		public ChatRoomDic RoomDic
		{
			[Token(Token = "0x600445F")]
			[Address(RVA = "0x930F", Offset = "0x930F", VA = "0x930F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004460")]
			[Address(RVA = "0x9310", Offset = "0x9310", VA = "0x9310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x9311", Offset = "0x9311", VA = "0x9311", Slot = "1")]
		protected override void Finalize()
		{
		/* --- GHIDRA: Finalize ---
		void Gameplay_Chat_Model_Data_ChatRoomData__Finalize
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57b50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatMessageItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b50 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,param4,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x10);
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ChatMessageItem__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,param2_00,Method_System_Collections_Generic_List_ChatMessageItem___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x9312", Offset = "0x9312", VA = "0x9312")]
		public ChatRoomData(RoomRight roomRight, ChatRoomDic dic, int startVisitorCapacity)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Chat_Model_Data_ChatRoomData___ctor(int param1,undefined4 param2)
		
		{
		  return *(uint *)(*(int *)(param1 + 0x14) + 0x10) & 1;
		}
		*/

		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x17000D7D")]
		public bool JoinAllowed
		{
			[Token(Token = "0x6004463")]
			[Address(RVA = "0x9313", Offset = "0x9313", VA = "0x9313")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x9314", Offset = "0x9314", VA = "0x9314")]
		public bool TryGetVisitor(string nick, out ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<ChatVisitorData> Visitors;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<ChatMessageItem> Messages;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_NotViewedMessagesCount ---
		void Gameplay_Chat_Model_Data_ChatRoomData__set_NotViewedMessagesCount(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatMessageItem__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Clear__);
		    DAT_ram_00a57b4f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar1 = *(int *)(param1 + 8);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_RoomDic ---
		void Gameplay_Chat_Model_Data_ChatRoomData__set_RoomDic(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  int local_c;
		  int *local_8;
		  int local_4;
		  
		  local_8 = &local_4;
		  local_c = 0;
		  local_4 = param1;
		  if (DAT_ram_00a57b4f == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&Method_System_Collections_Generic_List_ChatMessageItem__Clear__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e26a8b;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&Method_System_Collections_Generic_List_ChatVisitorData__Clear__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) goto code_r0x80e26a8b;
		    DAT_ram_00a57b4f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar2 = *(int *)(param1 + 8);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar3) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,*(undefined4 *)(iVar2 + 8),0,
		               iVar3,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) goto code_r0x80e26a8b;
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (iVar3 < 1) {
		    return;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiii
		            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,*(undefined4 *)(iVar2 + 8),0,
		             iVar3,0);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    return;
		  }
		code_r0x80e26a8b:
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x29,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_JoinAllowed ---
		undefined4
		Gameplay_Chat_Model_Data_ChatRoomData__get_JoinAllowed
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57b51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b51 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 8) + 0xc);
		  if (iVar3 < 1) {
		code_r0x80e26c96:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 8),0,
		                     Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		  *param3 = iVar2;
		  iVar2 = System_Collections_CollectionBase___ctor
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0x18),param2,0);
		  if (iVar2 == 0) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x80e26c96;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 8),param2_00,
		                         Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		      *param3 = iVar2;
		      iVar2 = System_Collections_CollectionBase___ctor
		                        (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0x18),param2,0);
		    } while (iVar2 == 0);
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

}
