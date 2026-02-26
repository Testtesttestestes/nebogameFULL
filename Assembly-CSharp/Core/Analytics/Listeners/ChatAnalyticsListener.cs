using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012C7 RID: 4807
	[Token(Token = "0x20012C7")]
	public class ChatAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172B")]
		protected override string Theme
		{
			[Token(Token = "0x6007240")]
			[Address(RVA = "0xBC49", Offset = "0xBC49", VA = "0xBC49", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007241")]
		[Address(RVA = "0xBC4A", Offset = "0xBC4A", VA = "0xBC4A", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_ChatAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59597 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatScope_ChatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ChatAnalyticsListener_SendMessageEvent__);
		    DAT_ram_00a59597 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x70);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_ChatAnalyticsListener_SendMessageEvent__,0
		            );
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_ChatScope_ChatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ChatScope_ChatEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007242")]
		[Address(RVA = "0xBC4B", Offset = "0xBC4B", VA = "0xBC4B", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_ChatAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined8 local_18;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59598 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatMessage_Types_ChatMessageTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21128);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27750);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21127);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21125);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26654);
		    DAT_ram_00a59598 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar2 = Core_Extensions_Dict_ChatBanDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 0x1c),0);
		  func_ii_2946(param1_00,StringLiteral_21128,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param1_00,StringLiteral_21125,*(undefined4 *)(param2 + 0x14),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_4 = *(undefined4 *)(param2 + 0x18);
		  local_8 = 0xffffffff;
		  local_c = Protocol_Chat_ChatMessage_Types_ChatMessageTypes_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  func_ii_2946(param1_00,StringLiteral_21127,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_18 = *(undefined8 *)(param2 + 0x20);
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_18);
		  func_ii_2946(param1_00,StringLiteral_27750,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_26654;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8102ff8b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8102ff8b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007243 RID: 29251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007243")]
		[Address(RVA = "0xBC4C", Offset = "0xBC4C", VA = "0xBC4C")]
		private void SendMessageEvent(ChatScope.ChatEventArgs e)
		{
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007244")]
		[Address(RVA = "0xBC4D", Offset = "0xBC4D", VA = "0xBC4D")]
		public ChatAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_ChatAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59599 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21185);
		    DAT_ram_00a59599 = '\x01';
		  }
		  return StringLiteral_21185;
		}
		*/

		}

		// Token: 0x04003BE0 RID: 15328
		[Token(Token = "0x4003BE0")]
		private const string SEND_MESSAGE = "send_message";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_ChatAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59596 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatScope_ChatEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_ChatAnalyticsListener_SendMessageEvent__);
		    DAT_ram_00a59596 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x70);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_ChatAnalyticsListener_SendMessageEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_ChatScope_ChatEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ChatScope_ChatEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_ChatScope_ChatEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
