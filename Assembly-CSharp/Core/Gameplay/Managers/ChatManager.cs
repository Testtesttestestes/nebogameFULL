using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001147 RID: 4423
	[Token(Token = "0x2001147")]
	public class ChatManager : IGameManager, IBaseManager
	{
		// Token: 0x1400026A RID: 618
		// (add) Token: 0x06006810 RID: 26640 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006810")]
			[Address(RVA = "0xB33C", Offset = "0xB33C", VA = "0xB33C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006811")]
			[Address(RVA = "0xB33D", Offset = "0xB33D", VA = "0xB33D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026B RID: 619
		// (add) Token: 0x06006812 RID: 26642 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006813 RID: 26643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006812")]
			[Address(RVA = "0xB33E", Offset = "0xB33E", VA = "0xB33E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006813")]
			[Address(RVA = "0xB33F", Offset = "0xB33F", VA = "0xB33F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006815 RID: 26645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001553")]
		public ChatController Controller
		{
			[Token(Token = "0x6006814")]
			[Address(RVA = "0xB340", Offset = "0xB340", VA = "0xB340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006815")]
			[Address(RVA = "0xB341", Offset = "0xB341", VA = "0xB341")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006816")]
		[Address(RVA = "0xB342", Offset = "0xB342", VA = "0xB342")]
		public ChatManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ChatManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  undefined4 param1_00;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  undefined4 param5;
		  int iVar13;
		  int *piVar14;
		  
		  iVar13 = 0;
		  if (DAT_ram_00a5a9ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Control_ChatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_ChatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_ChatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatUserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatVisitorData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatSmileDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatSmileDic__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_SmilesTags_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_573);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4178);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4179);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2348);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17001);
		    DAT_ram_00a5a9ca = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x178);
		        goto code_r0x812a384d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a384d:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		  iVar11 = Core_Gameplay_Managers_DictManager___ctor(uVar4,0x13,0);
		  if (iVar11 != 0) {
		    uVar4 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar4,
		               Method_System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags___ctor__
		              );
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar11 = *piVar10;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x178);
		          goto code_r0x812a3919;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a3919:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		    iVar11 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		    iVar11 = *(int *)(*(int *)(iVar11 + 0x1d4) + 0xc);
		    if (0 < iVar11) {
		      do {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		              puVar3 = (uint *)(piVar14[1] * 8 + iVar12 + 0x178);
		              goto code_r0x812a39d5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a39d5:
		        uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		        iVar12 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		        iVar12 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                           (*(undefined4 *)(iVar12 + 0x1d4),iVar13,
		                            Method_Google_Protobuf_Collections_RepeatedField_ChatSmileDic__get_Item__
		                           );
		        uVar5 = *(undefined4 *)(iVar12 + 0x10);
		        if (*(int *)(Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo + 0x74) == 0)
		        {
		          func_ii_306000(Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo);
		        }
		        iVar6 = System_UriBuilder___ctor
		                          (uVar5,**(undefined4 **)
		                                   (
		                                   Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo
		                                   + 0x5c),0,0);
		        if (0 < *(int *)(iVar6 + 0xc)) {
		          iVar2 = 0;
		          do {
		            uVar5 = *(undefined4 *)(iVar6 + iVar2 * 4 + 0x10);
		            uVar7 = *(undefined4 *)(iVar12 + 0x18);
		            if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_IO_Path_TypeInfo);
		            }
		            uVar7 = Spine_SkeletonJson__ReadSkeletonData(uVar7,0);
		            uVar7 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                              (StringLiteral_2348,uVar7,StringLiteral_573,0);
		            uVar8 = Spine_SkeletonJson__ReadSkeletonData(*(undefined4 *)(iVar12 + 0x18),0);
		            uVar8 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                              (StringLiteral_2347,uVar8,StringLiteral_573,0);
		            uVar9 = unnamed_function_1417
		                              (
		                              Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_SmilesTags_TypeInfo
		                              );
		            UnityEngine_Purchasing_Default_Factory__Create(uVar9,uVar7,uVar8,0);
		            System_Reflection_FieldInfo__get_IsStatic
		                      (uVar4,uVar5,uVar9,
		                       Method_System_Collections_Generic_Dictionary_string__ChatMsgPresenter_SmilesTags__Add__
		                      );
		            iVar2 = iVar2 + 1;
		          } while (iVar2 < *(int *)(iVar6 + 0xc));
		        }
		        iVar13 = iVar13 + 1;
		      } while (iVar13 != iVar11);
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_4178,1,0,1,0,0,0,0);
		    uVar7 = func_ii_7508(StringLiteral_4169,1,0,1,0,0,0,0);
		    uVar8 = func_ii_7508(StringLiteral_4179,1,0,1,0,0,0,0);
		    uVar9 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter_TypeInfo)
		    ;
		    Gameplay_Chat_Model_Data_Message_Format_ChatMsgPresenter__set_PrivateMsgColor
		              (uVar9,uVar4,uVar5,uVar7,uVar8,0);
		    uVar4 = unnamed_function_1417(Gameplay_Chat_ChatEvents_TypeInfo);
		    piVar10 = *(int **)(param1 + 0x14);
		    iVar13 = *piVar10;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x178);
		          goto code_r0x812a3c04;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a3c04:
		    uVar1 = 0;
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		    piVar10 = *(int **)(param1 + 0x14);
		    iVar13 = *piVar10;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x140);
		          goto code_r0x812a3c89;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a3c89:
		    uVar1 = 0;
		    uVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		    uVar7 = func_ii_7112(uVar7,0);
		    piVar10 = *(int **)(param1 + 0x14);
		    iVar13 = *piVar10;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x158);
		          goto code_r0x812a3d14;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x812a3d14:
		    iVar13 = (**(code **)((ulonglong)*puVar3 * 4))(piVar10,puVar3[1]);
		    param5 = *(undefined4 *)(iVar13 + 0x14);
		    iVar13 = unnamed_function_1417(Protocol_Chat_ChatUserInfo_TypeInfo);
		    Protocol_Chat_ChatUserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar13,0);
		    iVar11 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		    Protocol_Common_UserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar11,0);
		    *(undefined8 *)(iVar11 + 0x10) = 0;
		    Protocol_Common_UserInfo__get_Nick(iVar11,StringLiteral_17001,0);
		    *(int *)(iVar13 + 0xc) = iVar11;
		    uVar8 = unnamed_function_1417(Gameplay_Chat_Model_Data_ChatVisitorData_TypeInfo);
		    Gameplay_Chat_Model_Data_ChatVisitorData__Finalize(uVar8,iVar13,0);
		    param1_00 = unnamed_function_1417(Gameplay_Chat_Model_ChatModel_TypeInfo);
		    Gameplay_Chat_Model_ChatModel__Dispose(param1_00,uVar5,uVar9,uVar7,param5,uVar8,0x10,0x14,0);
		    uVar5 = unnamed_function_1417(Gameplay_Chat_Control_ChatController_TypeInfo);
		    Gameplay_Chat_Control_ChatController__Dispose(uVar5,param1_00,uVar4,0);
		    *(undefined4 *)(param1 + 0x10) = uVar5;
		    MVC_AbstractController__Dispose(uVar5,0);
		  }
		  iVar13 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar13 + 0xc) * 4))
		            (*(undefined4 *)(iVar13 + 0x20),param1,*(undefined4 *)(iVar13 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006817 RID: 26647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006817")]
		[Address(RVA = "0xB343", Offset = "0xB343", VA = "0xB343", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ChatManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x10) != 0) {
		    MVC_AbstractController__Run(*(int *)(param1 + 0x10),0);
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006818 RID: 26648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006818")]
		[Address(RVA = "0xB344", Offset = "0xB344", VA = "0xB344", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_ChatManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5348);
		    DAT_ram_00a5a9cb = '\x01';
		  }
		  return StringLiteral_5348;
		}
		*/

		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001554")]
		public string Name
		{
			[Token(Token = "0x6006819")]
			[Address(RVA = "0xB345", Offset = "0xB345", VA = "0xB345", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681A")]
		[Address(RVA = "0xB346", Offset = "0xB346", VA = "0xB346")]
		public void RunBanProcess(ChatVisitorData visitor)
		{
		/* --- GHIDRA: RunBanProcess ---
		undefined4 Core_Gameplay_Managers_ChatManager__RunBanProcess(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9cd == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5470);
		    DAT_ram_00a5a9cd = '\x01';
		  }
		  return StringLiteral_5470;
		}
		*/

		}

		// Token: 0x04003777 RID: 14199
		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0x14")]
		private readonly IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ChatManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9c7 = '\x01';
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
		void Core_Gameplay_Managers_ChatManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9c8 = '\x01';
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
		void Core_Gameplay_Managers_ChatManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9c9 = '\x01';
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


		/* --- GHIDRA: get_Name ---
		/* WARNING: Removing unreachable block (ram,0x812a4246) */
		
		void Core_Gameplay_Managers_ChatManager__get_Name(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a9cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ChatBanArticleData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_Bans_ChatBanWindow_ChatBanWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ChatBanDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ChatBanArticleData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ChatBanWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatBanDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12584);
		    DAT_ram_00a5a9cc = '\x01';
		  }
		  iVar8 = **(int **)(param1 + 0x10);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar8 + 0x104));
		  if (*(int *)(iVar8 + 0x2c) == param2) {
		    return;
		  }
		  iVar8 = unnamed_function_1417(Gameplay_Chat_View_Bans_ChatBanWindow_ChatBanWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar8,0);
		  *(int *)(iVar8 + 0x18) = param2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_ChatBanArticleData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_ChatBanArticleData___ctor__);
		  *(undefined4 *)(iVar8 + 0x1c) = uVar2;
		  *(undefined4 *)(iVar8 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x812a3fe7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a3fe7:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar7 + 0x84),
		                              Method_Google_Protobuf_Collections_RepeatedField_ChatBanDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x812a40d1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812a434d:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812a4355;
		    }
		code_r0x812a40d1:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812a434d;
		    if (iVar7 == 0) {
		      iVar5 = 5;
		      iVar7 = 0;
		      goto code_r0x812a43a2;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ChatBanDic__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x812a41ab;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ChatBanDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812a432f:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812a4355;
		    }
		code_r0x812a41ab:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812a432f;
		    piVar6 = *(int **)(iVar8 + 0x1c);
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Chat_Model_Data_ChatBanArticleData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812a4355;
		    }
		    *(undefined4 *)(iVar7 + 8) = uVar2;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_ChatBanArticleData__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(piVar9[1] * 8 + iVar5 + 0xd0);
		          goto code_r0x812a42e3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        System_Collections_Generic_ICollection_ChatBanArticleData__TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x812a42e3:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar6,iVar7,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812a4355:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar7 = *piVar6;
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x812a43a2:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x812a441a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x812a441a:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      }
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar5 != 0) {
		        if (iVar5 == 1) {
		          return;
		        }
		        if (iVar5 == 2) {
		          return;
		        }
		        if (iVar5 == 3) {
		          return;
		        }
		        if (iVar5 == 4) {
		          return;
		        }
		        if (iVar5 != 5) {
		          return;
		        }
		      }
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		      Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                (uVar2,StringLiteral_12584,iVar8,
		                 Method_UI_Windows_PopupController_Show_ChatBanWindow___);
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x52,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar2);
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
