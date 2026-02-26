using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Chat;

namespace Gameplay.Chat.Model
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	public class ChatModel : AbstractModel, IFavoriteUsersProvider
	{
		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		// (set) Token: 0x0600441A RID: 17434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D67")]
		public int RoomsJoined
		{
			[Token(Token = "0x6004419")]
			[Address(RVA = "0x92CC", Offset = "0x92CC", VA = "0x92CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600441A")]
			[Address(RVA = "0x92CD", Offset = "0x92CD", VA = "0x92CD")]
			set
			{
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D68")]
		public IChatMsgPresenter MessagePresenter
		{
			[Token(Token = "0x600441B")]
			[Address(RVA = "0x92CE", Offset = "0x92CE", VA = "0x92CE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600441C")]
			[Address(RVA = "0x92CF", Offset = "0x92CF", VA = "0x92CF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D69")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600441D")]
			[Address(RVA = "0x92D0", Offset = "0x92D0", VA = "0x92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600441E")]
			[Address(RVA = "0x92D1", Offset = "0x92D1", VA = "0x92D1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6A")]
		public IUserCache UserCache
		{
			[Token(Token = "0x600441F")]
			[Address(RVA = "0x92D2", Offset = "0x92D2", VA = "0x92D2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004420")]
			[Address(RVA = "0x92D3", Offset = "0x92D3", VA = "0x92D3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x92D4", Offset = "0x92D4", VA = "0x92D4", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Chat_Model_ChatModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b39 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_RoomKey_TypeInfo);
		    DAT_ram_00a57b39 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData___ctor__);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0x28) = param5;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  *(undefined4 *)(param1 + 0x18) = param6;
		  *(undefined4 *)(param1 + 0x14) = param8;
		  *(undefined4 *)(param1 + 0x10) = param7;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ChatVisitorData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,param8,Method_System_Collections_Generic_List_ChatVisitorData___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  iVar2 = unnamed_function_1417(Protocol_Chat_RoomKey_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = 100;
		  *(int *)(param1 + 0xc) = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x92D5", Offset = "0x92D5", VA = "0x92D5")]
		public ChatModel([NotNull] IDictProvider dictProvider, [NotNull] IChatMsgPresenter presenter, [NotNull] UserData user, [NotNull] IUserCache userCache, [NotNull] ChatVisitorData defaultVisitor, int startVisitorsCapacity, int startFavoritesCapacity)
		{
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004424 RID: 17444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6B")]
		public ChatVisitorData ChatUser
		{
			[Token(Token = "0x6004423")]
			[Address(RVA = "0x92D6", Offset = "0x92D6", VA = "0x92D6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x92D7", Offset = "0x92D7", VA = "0x92D7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004426 RID: 17446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6C")]
		public ChatRoomData CurrentRoom
		{
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x92D8", Offset = "0x92D8", VA = "0x92D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004426")]
			[Address(RVA = "0x92D9", Offset = "0x92D9", VA = "0x92D9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004427")]
		[Address(RVA = "0x92DA", Offset = "0x92DA", VA = "0x92DA")]
		public void SetChatUser(ChatVisitorData user)
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004428")]
		[Address(RVA = "0x92DB", Offset = "0x92DB", VA = "0x92DB")]
		public void SetCurrentRoom(ChatRoomData room)
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D6D")]
		public List<ChatVisitorData> Favorites
		{
			[Token(Token = "0x6004429")]
			[Address(RVA = "0x92DC", Offset = "0x92DC", VA = "0x92DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6E")]
		public bool IsFavoritesPrepared
		{
			[Token(Token = "0x600442A")]
			[Address(RVA = "0x92DD", Offset = "0x92DD", VA = "0x92DD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600442B")]
			[Address(RVA = "0x92DE", Offset = "0x92DE", VA = "0x92DE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x92DF", Offset = "0x92DF", VA = "0x92DF")]
		public ChatVisitorData AddFavorite(ChatVisitorData visitor)
		{
		/* --- GHIDRA: AddFavorite ---
		uint Gameplay_Chat_Model_ChatModel__AddFavorite(int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  if (DAT_ram_00a57b3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b3b = '\x01';
		  }
		  param2_00 = *(int *)(*(int *)(param1 + 0x34) + 0xc);
		  do {
		    iVar1 = param2_00;
		    if (iVar1 < 1) goto code_r0x80e25cc2;
		    param2_00 = iVar1 + -1;
		    iVar2 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x34),param2_00,
		                       Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		  } while (*(longlong *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0x10) != param2);
		  UnityEngine_TextCore_Glyph__set_atlasIndex
		            (*(undefined4 *)(param1 + 0x34),param2_00,
		             Method_System_Collections_Generic_List_ChatVisitorData__RemoveAt__);
		code_r0x80e25cc2:
		  return (uint)(0 < iVar1);
		}
		*/

			return null;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x92E0", Offset = "0x92E0", VA = "0x92E0")]
		public bool RemoveFavorite(ulong userId)
		{
		/* --- GHIDRA: RemoveFavorite ---
		uint Gameplay_Chat_Model_ChatModel__RemoveFavorite
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57b3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b3d = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x34) + 0xc);
		  do {
		    iVar2 = iVar1;
		    if (iVar2 < 1) {
		      *param3 = 0;
		      break;
		    }
		    iVar3 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x34),iVar2 + -1,
		                       Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    *param3 = iVar3;
		    iVar1 = iVar2 + -1;
		  } while (param2 != *(longlong *)(*(int *)(*(int *)(iVar3 + 0x14) + 0xc) + 0x10));
		  return (uint)(0 < iVar2);
		}
		*/

		/* --- GHIDRA: RemoveFavorite ---
		uint Gameplay_Chat_Model_ChatModel__RemoveFavorite
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57b3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    DAT_ram_00a57b3d = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x34) + 0xc);
		  do {
		    iVar2 = iVar1;
		    if (iVar2 < 1) {
		      *param3 = 0;
		      break;
		    }
		    iVar3 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0x34),iVar2 + -1,
		                       Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    *param3 = iVar3;
		    iVar1 = iVar2 + -1;
		  } while (param2 != *(longlong *)(*(int *)(*(int *)(iVar3 + 0x14) + 0xc) + 0x10));
		  return (uint)(0 < iVar2);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x92E1", Offset = "0x92E1", VA = "0x92E1")]
		public bool RemoveFavorite(ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x92E2", Offset = "0x92E2", VA = "0x92E2")]
		public bool TryGetFavorite(ulong userId, out ChatVisitorData visitor)
		{
		/* --- GHIDRA: TryGetFavorite ---
		undefined4
		Gameplay_Chat_Model_ChatModel__TryGetFavorite
		          (int param1,longlong param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__);
		    DAT_ram_00a57b3e = '\x01';
		  }
		  if (param2 != 0) {
		    uVar1 = func_ii_7090(*(undefined4 *)(param1 + 0x3c),param2,param3,
		                         Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                        );
		    return uVar1;
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x92E3", Offset = "0x92E3", VA = "0x92E3")]
		public bool TryGetVisitor(ulong userId, out ChatVisitorData visitor)
		{
		/* --- GHIDRA: TryGetVisitor ---
		int Gameplay_Chat_Model_ChatModel__TryGetVisitor(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57b3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Add__);
		    DAT_ram_00a57b3f = '\x01';
		  }
		  BestHTTP_Caching_HTTPCacheFileInfo___ctor
		            (*(undefined4 *)(param1 + 0x3c),
		             *(undefined8 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x10),param2,
		             Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Add__);
		  return param2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x92E4", Offset = "0x92E4", VA = "0x92E4")]
		public ChatVisitorData AddVisitor(ChatVisitorData visitor)
		{
		/* --- GHIDRA: AddVisitor ---
		int Gameplay_Chat_Model_ChatModel__AddVisitor
		              (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  int local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57b40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__);
		    DAT_ram_00a57b40 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param3 + 0x1c),param2,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a57b45 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__)
		      ;
		      DAT_ram_00a57b45 = '\x01';
		    }
		    iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                      (*(undefined4 *)(param1 + 0x40),param2,&local_4,
		                       Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                      );
		    if (iVar2 != 0) {
		      System_Reflection_FieldInfo__get_IsStatic
		                (*(undefined4 *)(param3 + 0x1c),param2,local_4,
		                 Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		      iVar1 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		      iVar2 = *(int *)(local_4 + 8);
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar3 = *(uint *)(iVar2 + 0xc);
		      if (uVar3 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		        *(uint *)(iVar2 + 0xc) = uVar3 + 1;
		        *(int *)(*(int *)(iVar2 + 8) + uVar3 * 4 + 0x10) = param3;
		        iVar1 = local_4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar2,param3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        iVar1 = local_4;
		      }
		    }
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x92E5", Offset = "0x92E5", VA = "0x92E5")]
		public ChatRoomData AddVisitorToRoom(RoomKey roomKey, ChatVisitorData visitor)
		{
		/* --- GHIDRA: AddVisitorToRoom ---
		int Gameplay_Chat_Model_ChatModel__AddVisitorToRoom
		              (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57b41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		    DAT_ram_00a57b41 = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a57b45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    DAT_ram_00a57b45 = '\x01';
		  }
		  iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(param3 + 0x1c),param2,
		               Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		    func_ii_4876(*(undefined4 *)(local_4 + 8),param3,
		                 Method_System_Collections_Generic_List_ChatVisitorData__Remove__);
		    iVar1 = local_4;
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x92E6", Offset = "0x92E6", VA = "0x92E6")]
		public ChatRoomData RemoveVisitorFromRoom(RoomKey roomKey, ChatVisitorData visitor)
		{
		/* --- GHIDRA: RemoveVisitorFromRoom ---
		undefined4
		Gameplay_Chat_Model_ChatModel__RemoveVisitorFromRoom
		          (int param1,undefined4 param2,int param3,int *param4,undefined4 param5)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a57b42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		    DAT_ram_00a57b42 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if ((iVar1 != 0) && (iVar1 = *(int *)(*(int *)(local_4 + 0xc) + 0xc), 0 < iVar1)) {
		    param2_00 = 0;
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(local_4 + 0xc),param2_00,
		                         Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		      *param4 = iVar2;
		      if (param3 == *(int *)(*(int *)(iVar2 + 0xc) + 8)) {
		        return 1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  *param4 = 0;
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x92E7", Offset = "0x92E7", VA = "0x92E7")]
		public bool TryGetMessage(RoomKey roomKey, uint messageId, out ChatMessageItem messageItem)
		{
		/* --- GHIDRA: TryGetMessage ---
		undefined4
		Gameplay_Chat_Model_ChatModel__TryGetMessage
		          (int param1,undefined4 param2,int param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57b44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		    DAT_ram_00a57b44 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		code_r0x80e262cf:
		    *param4 = 0;
		    uVar3 = 0;
		  }
		  else {
		    iVar1 = *(int *)(*(int *)(local_4 + 0xc) + 0xc);
		    do {
		      if (iVar1 < 1) goto code_r0x80e262cf;
		      iVar1 = iVar1 + -1;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(local_4 + 0xc),iVar1,
		                         Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		      *param4 = iVar2;
		    } while (*(int *)(*(int *)(iVar2 + 0xc) + 8) != param3);
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(local_4 + 0xc),iVar1,
		               Method_System_Collections_Generic_List_ChatMessageItem__RemoveAt__);
		    uVar3 = 1;
		  }
		  return uVar3;
		}
		*/

		/* --- GHIDRA: TryGetMessage ---
		undefined4
		Gameplay_Chat_Model_ChatModel__TryGetMessage
		          (int param1,undefined4 param2,int param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a57b44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		    DAT_ram_00a57b44 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x40),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		code_r0x80e262cf:
		    *param4 = 0;
		    uVar3 = 0;
		  }
		  else {
		    iVar1 = *(int *)(*(int *)(local_4 + 0xc) + 0xc);
		    do {
		      if (iVar1 < 1) goto code_r0x80e262cf;
		      iVar1 = iVar1 + -1;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(local_4 + 0xc),iVar1,
		                         Method_System_Collections_Generic_List_ChatMessageItem__get_Item__);
		      *param4 = iVar2;
		    } while (*(int *)(*(int *)(iVar2 + 0xc) + 8) != param3);
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(local_4 + 0xc),iVar1,
		               Method_System_Collections_Generic_List_ChatMessageItem__RemoveAt__);
		    uVar3 = 1;
		  }
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x92E8", Offset = "0x92E8", VA = "0x92E8")]
		public bool TryGetMessage(RoomKey roomKey, uint messageId, out ChatMessageData message)
		{
			return default(bool);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x1BB5", Offset = "0x1BB5", VA = "0x1BB5")]
		public ChatMessageItem AddMessage(RoomKey roomKey, ChatMessageData messageData)
		{
		/* --- GHIDRA: AddMessage ---
		void Gameplay_Chat_Model_ChatModel__AddMessage(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint uVar3;
		  uint uVar4;
		  uint uVar5;
		  int iVar6;
		  uint uVar7;
		  uint uVar8;
		  int iVar9;
		  int iVar10;
		  ulonglong local_10;
		  ulonglong local_8;
		  
		  uVar7 = 0;
		  *(int *)(param2 + 0x10) = *(int *)(param2 + 0x10) + 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x48);
		  if (iVar1 != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = Gameplay_Chat_Model_ChatModel__AddRoom(param1_00,param1);
		    if (DAT_ram_00a57b83 == '\0') {
		      Mono_Security_ASN1__get_Item(&int___TypeInfo);
		      DAT_ram_00a57b83 = '\x01';
		    }
		    uVar3 = Mono_Security_ASN1Convert__ToOid(int___TypeInfo,*(undefined4 *)(iVar2 + 0xc));
		    uVar4 = *(uint *)(iVar2 + 0xc);
		    if ((int)uVar4 < 1) {
		      local_10 = 0;
		    }
		    else {
		      if (uVar4 == 1) {
		        uVar5 = 0;
		        iVar6 = 0;
		      }
		      else {
		        uVar5 = 0;
		        iVar6 = 0;
		        do {
		          uVar8 = iVar6 * 4;
		          iVar9 = *(int *)(iVar2 + 0x10 + uVar8);
		          *(undefined4 *)(uVar3 + 0x10 + uVar8) = *(undefined4 *)(iVar9 + 0x10);
		          iVar9 = *(int *)(iVar9 + 0x10);
		          iVar10 = *(int *)((uVar8 | 4) + iVar2 + 0x10);
		          *(undefined4 *)(uVar3 + 0x10 + (uVar8 | 4)) = *(undefined4 *)(iVar10 + 0x10);
		          uVar5 = *(int *)(iVar10 + 0x10) + uVar5 + iVar9;
		          iVar6 = iVar6 + 2;
		          uVar7 = uVar7 + 2;
		        } while (uVar7 != (uVar4 & 0xfffffffe));
		      }
		      if ((uVar4 & 1) != 0) {
		        iVar2 = *(int *)(iVar6 * 4 + iVar2 + 0x10);
		        *(undefined4 *)(uVar3 + iVar6 * 4 + 0x10) = *(undefined4 *)(iVar2 + 0x10);
		        uVar5 = *(int *)(iVar2 + 0x10) + uVar5;
		      }
		      local_10 = (ulonglong)uVar5;
		    }
		    local_10 = (ulonglong)uVar3 << 0x20 | local_10;
		    local_8 = local_10;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),&local_10,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x92E9", Offset = "0x92E9", VA = "0x92E9")]
		public bool TryRemoveMessage(RoomKey roomKey, uint messageId, out ChatMessageItem message)
		{
		/* --- GHIDRA: TryRemoveMessage ---
		undefined4
		Gameplay_Chat_Model_ChatModel__TryRemoveMessage
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__);
		    DAT_ram_00a57b45 = '\x01';
		  }
		  uVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0x40),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x92EA", Offset = "0x92EA", VA = "0x92EA")]
		public bool TryGetRoom(RoomKey roomKey, out ChatRoomData room)
		{
		/* --- GHIDRA: TryGetRoom ---
		void Gameplay_Chat_Model_ChatModel__TryGetRoom(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57b46 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__get_Item__);
		    DAT_ram_00a57b46 = '\x01';
		  }
		  System_Data_DataRelationCollection__Add
		            (*(undefined4 *)(param1 + 0x40),param2,
		             Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__get_Item__);
		  System_Linq_Enumerable__First_KeyValuePair_object__object__
		            (*(undefined4 *)(param1 + 0x40),param2,
		             Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Remove__);
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x92EB", Offset = "0x92EB", VA = "0x92EB")]
		public void RemoveRoom(RoomKey roomKey)
		{
		/* --- GHIDRA: RemoveRoom ---
		int Gameplay_Chat_Model_ChatModel__RemoveRoom(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57b47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		    DAT_ram_00a57b47 = '\x01';
		  }
		  System_Reflection_FieldInfo__get_IsStatic
		            (*(undefined4 *)(param1 + 0x40),*(undefined4 *)(*(int *)(param2 + 0x14) + 0xc),param2,
		             Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Add__);
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return param2;
		}
		*/

		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x92EC", Offset = "0x92EC", VA = "0x92EC")]
		public ChatRoomData AddRoom(ChatRoomData room)
		{
		/* --- GHIDRA: AddRoom ---
		int Gameplay_Chat_Model_ChatModel__AddRoom(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57b48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ChatRoomData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_KeyValuePair_RoomKey__ChatRoomData___ChatRoomData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ChatRoomData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatRoomData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_RoomKey__ChatRoomData___ChatRoomData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_Model_ChatModel___c__GetRooms_b__57_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Chat_Model_ChatModel___c__GetRooms_b__57_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		    DAT_ram_00a57b48 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x40);
		    if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[1];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar3;
		      iVar1 = unnamed_function_1417
		                        (System_Func_KeyValuePair_RoomKey__ChatRoomData___ChatRoomData__TypeInfo);
		      func_ii_7795(iVar1,uVar4,Method_Gameplay_Chat_Model_ChatModel___c__GetRooms_b__57_0__,0);
		      *(int *)(*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c) + 4) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar2,iVar1,
		                       Method_System_Linq_Enumerable_Select_KeyValuePair_RoomKey__ChatRoomData___ChatRoomData___
		                      );
		    if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_ChatRoomData__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar1,uVar4,Method_Gameplay_Chat_Model_ChatModel___c__GetRooms_b__57_1__,0);
		      *(int *)(*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c) + 8) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (uVar2,iVar1,Method_System_Linq_Enumerable_OrderBy_ChatRoomData__uint___);
		    iVar1 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ChatRoomData___);
		    *(int *)(param1 + 0x44) = iVar1;
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x92ED", Offset = "0x92ED", VA = "0x92ED")]
		public ChatRoomData[] GetRooms()
		{
		/* --- GHIDRA: GetRooms ---
		undefined4 Gameplay_Chat_Model_ChatModel__GetRooms(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57b49 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21126);
		    DAT_ram_00a57b49 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x24);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e265cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e265cc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_21126,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D6F")]
		public string MessagePatterString
		{
			[Token(Token = "0x600443C")]
			[Address(RVA = "0x92EE", Offset = "0x92EE", VA = "0x92EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x17000D70")]
		public int MaxMessageSize
		{
			[Token(Token = "0x600443D")]
			[Address(RVA = "0x92EF", Offset = "0x92EF", VA = "0x92EF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D71")]
		public RoomVisitorsOrContactsStates CurrentUIVisitorsState
		{
			[Token(Token = "0x600443E")]
			[Address(RVA = "0x92F0", Offset = "0x92F0", VA = "0x92F0")]
			[CompilerGenerated]
			get
			{
				return RoomVisitorsOrContactsStates.ROOM_VISITORS;
			}
			[Token(Token = "0x600443F")]
			[Address(RVA = "0x92F1", Offset = "0x92F1", VA = "0x92F1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D72")]
		public MiniChatButtonStates CurrentMiniChatViewState
		{
			[Token(Token = "0x6004440")]
			[Address(RVA = "0x92F2", Offset = "0x92F2", VA = "0x92F2")]
			[CompilerGenerated]
			get
			{
				return MiniChatButtonStates.ROLLED_UP;
			}
			[Token(Token = "0x6004441")]
			[Address(RVA = "0x92F3", Offset = "0x92F3", VA = "0x92F3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D73")]
		public PrivateOrAllMessagesStates CurrentMessagesState
		{
			[Token(Token = "0x6004442")]
			[Address(RVA = "0x92F4", Offset = "0x92F4", VA = "0x92F4")]
			[CompilerGenerated]
			get
			{
				return PrivateOrAllMessagesStates.ALL;
			}
			[Token(Token = "0x6004443")]
			[Address(RVA = "0x92F5", Offset = "0x92F5", VA = "0x92F5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x92F6", Offset = "0x92F6", VA = "0x92F6", Slot = "6")]
		public UserData[] GetFavoriteUsers()
		{
		/* --- GHIDRA: GetFavoriteUsers ---
		void Gameplay_Chat_Model_ChatModel__GetFavoriteUsers(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b4c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		    DAT_ram_00a57b4c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[FieldOffset(Offset = "0xC")]
		public readonly RoomKey ComplaintsAggregatorRoomKey;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[FieldOffset(Offset = "0x10")]
		public readonly int StartVisitorsCapacity;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[FieldOffset(Offset = "0x14")]
		public readonly int StartFavoritesCapacity;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[FieldOffset(Offset = "0x18")]
		public readonly ChatVisitorData DefaultVisitorData;

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x1C")]
		private int _roomsJoined;

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Dictionary<ulong, ChatVisitorData> _visitors;

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<RoomKey, ChatRoomData> _rooms;

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		[FieldOffset(Offset = "0x44")]
		private ChatRoomData[] _sortedRoomsCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RoomsJoined ---
		void Gameplay_Chat_Model_ChatModel__get_RoomsJoined(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x1c)) {
		    if (param2 < 1) {
		      param2 = 0;
		    }
		    *(int *)(param1 + 0x1c) = param2;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_UserCache ---
		void Gameplay_Chat_Model_ChatModel__set_UserCache(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a57b38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Clear__);
		    DAT_ram_00a57b38 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x40),
		             Method_System_Collections_Generic_Dictionary_RoomKey__ChatRoomData__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__Clear__);
		  iVar1 = *(int *)(param1 + 0x34);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0x30) = 0;
		  *(undefined8 *)(param1 + 0x28) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_IsFavoritesPrepared ---
		undefined4
		Gameplay_Chat_Model_ChatModel__set_IsFavoritesPrepared
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a57b3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ChatVisitorData__Add__);
		    DAT_ram_00a57b3a = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_ChatVisitorData__Add__;
		  param1_00 = *(int *)(param1 + 0x34);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return param2;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param2;
		}
		*/


		/* --- GHIDRA: get_MessagePatterString ---
		undefined4 Gameplay_Chat_Model_ChatModel__get_MessagePatterString(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57b4a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25314);
		    DAT_ram_00a57b4a = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x24);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e26689;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e26689:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_25314,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_CurrentMessagesState ---
		undefined4 Gameplay_Chat_Model_ChatModel__set_CurrentMessagesState(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57b4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_ChatVisitorData__UserData___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ChatVisitorData__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_Model_ChatModel___c__GetFavoriteUsers_b__74_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		    DAT_ram_00a57b4b = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Chat_Model_ChatModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ChatVisitorData__UserData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,param2_00,
		               Method_Gameplay_Chat_Model_ChatModel___c__GetFavoriteUsers_b__74_0__,0);
		    *(int *)(*(int *)(Gameplay_Chat_Model_ChatModel___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_ChatVisitorData__UserData___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_UserData___);
		  return uVar1;
		}
		*/

}
