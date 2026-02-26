using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Rating;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public class RatingService : AbstractService
	{
		// Token: 0x14000092 RID: 146
		// (add) Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000092")]
		public event Action<ProtoTotalRatingChangedEvt> TotalRatingChangedEvent
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x5A04", Offset = "0x5A04", VA = "0x5A04")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x5A05", Offset = "0x5A05", VA = "0x5A05")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000604 RID: 1540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000093")]
		public event Action<ProtoGreatRatingTopChangedEvt> GreatRatingTopChangedEvent
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x5A06", Offset = "0x5A06", VA = "0x5A06")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x5A07", Offset = "0x5A07", VA = "0x5A07")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000094")]
		public event Action<ProtoGreatRatingSetChangedEvt> GreatRatingSetChangedEvent
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x5A08", Offset = "0x5A08", VA = "0x5A08")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x5A09", Offset = "0x5A09", VA = "0x5A09")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000095")]
		public event Action<ProtoCompetitionRatingChangedEvt> CompetitionRatingChangedEvent
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x5A0A", Offset = "0x5A0A", VA = "0x5A0A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x5A0B", Offset = "0x5A0B", VA = "0x5A0B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x170000A9")]
		public override short ServiceId
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x5A0C", Offset = "0x5A0C", VA = "0x5A0C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5A0D", Offset = "0x5A0D", VA = "0x5A0D", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4
		ServicesNamespace_RatingService__ServerEventHandler
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetUsersRatingAns___);
		    DAT_ram_00a55a18 = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,1,param2,param3,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetUsersRatingAns___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5A0E", Offset = "0x5A0E", VA = "0x5A0E")]
		public OpToken<IMessage, object> RequestUsersRating(uint ratingType, RatingPeriods periods)
		{
		/* --- GHIDRA: RequestUsersRating ---
		undefined4
		ServicesNamespace_RatingService__RequestUsersRating
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetCultsRatingAns___);
		    DAT_ram_00a55a19 = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,2,param2,param3,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetCultsRatingAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x5A0F", Offset = "0x5A0F", VA = "0x5A0F")]
		public OpToken<IMessage, object> RequestCultRating(uint ratingType, RatingPeriods periods)
		{
		/* --- GHIDRA: RequestCultRating ---
		undefined4
		ServicesNamespace_RatingService__RequestCultRating
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetClansRatingAns___);
		    DAT_ram_00a55a1a = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,3,param2,param3,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetClansRatingAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x5A10", Offset = "0x5A10", VA = "0x5A10")]
		public OpToken<IMessage, object> RequestClansRating(uint ratingType, RatingPeriods periods)
		{
		/* --- GHIDRA: RequestClansRating ---
		undefined4
		ServicesNamespace_RatingService__RequestClansRating
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetUserTDRatingAns___);
		    DAT_ram_00a55a1b = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,0xb,0,param2,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetUserTDRatingAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5A11", Offset = "0x5A11", VA = "0x5A11")]
		public OpToken<IMessage, object> GetUserTdRating(RatingPeriods periods)
		{
		/* --- GHIDRA: GetUserTdRating ---
		undefined4
		ServicesNamespace_RatingService__GetUserTdRating
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetAllUsersTDRatingAns___);
		    DAT_ram_00a55a1c = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,0xc,0,param2,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetAllUsersTDRatingAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5A12", Offset = "0x5A12", VA = "0x5A12")]
		public OpToken<IMessage, object> GetAllUsersTdRating(RatingPeriods periods)
		{
		/* --- GHIDRA: GetAllUsersTdRating ---
		undefined4 ServicesNamespace_RatingService__GetAllUsersTdRating(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetUserPortalRatingAns___);
		    DAT_ram_00a55a1d = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,0xd,0,0,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetUserPortalRatingAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5A13", Offset = "0x5A13", VA = "0x5A13")]
		public OpToken<IMessage, object> GetUserPortalRating()
		{
		/* --- GHIDRA: GetUserPortalRating ---
		undefined4 ServicesNamespace_RatingService__GetUserPortalRating(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_RatingService_GetRating_ProtoGetAllUsersPortalRatingAns___)
		    ;
		    DAT_ram_00a55a1e = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_PurchasingFactory__RegisterExtension___Il2CppFullySharedGenericType_
		                    (param1,0xe,0,0,
		                     Method_ServicesNamespace_RatingService_GetRating_ProtoGetAllUsersPortalRatingAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5A14", Offset = "0x5A14", VA = "0x5A14")]
		public OpToken<IMessage, object> GetAllUsersPortalRating()
		{
		/* --- GHIDRA: GetAllUsersPortalRating ---
		int * ServicesNamespace_RatingService__GetAllUsersPortalRating(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a1f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetGreatTopAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a1f = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,0,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetGreatTopAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000612")]
		private OpToken<IMessage, object> GetRating<TAns>(RatingCommands command, uint ratingType, RatingPeriods periods) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5A15", Offset = "0x5A15", VA = "0x5A15")]
		public OpToken<IMessage, object> GetGreatTop()
		{
		/* --- GHIDRA: GetGreatTop ---
		int * ServicesNamespace_RatingService__GetGreatTop(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a20 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoSetGreatSetIdCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a20 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Rating_ProtoSetGreatSetIdCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,6,iVar1,0);
		    local_8 = 0x6ffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5A16", Offset = "0x5A16", VA = "0x5A16")]
		public OpToken<IMessage, object> SetGreatSetId(uint greatSetId)
		{
		/* --- GHIDRA: SetGreatSetId ---
		int * ServicesNamespace_RatingService__SetGreatSetId
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoVoteGreatRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoVoteGreatRatingAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a21 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Rating_ProtoVoteGreatRatingCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoVoteGreatRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5A17", Offset = "0x5A17", VA = "0x5A17")]
		public OpToken<IMessage, object> VoteGreatRating(ulong userId)
		{
		/* --- GHIDRA: VoteGreatRating ---
		int * ServicesNamespace_RatingService__VoteGreatRating(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a22 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a22 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,0,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5A18", Offset = "0x5A18", VA = "0x5A18")]
		public OpToken<IMessage, object> ExitGreatRating()
		{
		/* --- GHIDRA: ExitGreatRating ---
		int * ServicesNamespace_RatingService__ExitGreatRating
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoVoteRTRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a23 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Rating_ProtoVoteRTRatingCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    *(undefined1 *)(iVar1 + 0x18) = (undefined1)param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,iVar1,0);
		    local_8 = 0x9ffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x5A19", Offset = "0x5A19", VA = "0x5A19")]
		public OpToken<IMessage, object> VoteRTRating(ulong userId, bool isLike)
		{
		/* --- GHIDRA: VoteRTRating ---
		int * ServicesNamespace_RatingService__VoteRTRating
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a55a24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetVoteRTRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetVoteRTRatingAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a24 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Rating_ProtoGetVoteRTRatingCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0x10) = (undefined1)param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetVoteRTRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5A1A", Offset = "0x5A1A", VA = "0x5A1A")]
		public OpToken<IMessage, object> GetVoteRTRating(RatingPeriods period, bool ownerOnly)
		{
		/* --- GHIDRA: GetVoteRTRating ---
		int * ServicesNamespace_RatingService__GetVoteRTRating(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a55a25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionRatingCounterAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a25 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = unnamed_function_1417(Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar3,0x10,uVar2,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionRatingCounterAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5A1B", Offset = "0x5A1B", VA = "0x5A1B")]
		public OpToken<IMessage, object> GetCompetitionRatingCounter()
		{
		/* --- GHIDRA: GetCompetitionRatingCounter ---
		int * ServicesNamespace_RatingService__GetCompetitionRatingCounter(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a55a26 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionRatingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55a26 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = unnamed_function_1417(Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar3,0xf,uVar2,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionRatingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x5A1C", Offset = "0x5A1C", VA = "0x5A1C")]
		public OpToken<IMessage, object> GetCompetitionRating()
		{
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x5A1D", Offset = "0x5A1D", VA = "0x5A1D")]
		public RatingService()
		{
		/* --- GHIDRA: .ctor ---
		int ServicesNamespace_RatingService___ctor(int param1,undefined4 param2)
		
		{
		  return (int)*(short *)(param1 + 0x14);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TotalRatingChangedEvent ---
		void ServicesNamespace_RatingService__add_TotalRatingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a10 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTotalRatingChangedEvt__TypeInfo);
		    DAT_ram_00a55a10 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTotalRatingChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTotalRatingChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_TotalRatingChangedEvent ---
		void ServicesNamespace_RatingService__remove_TotalRatingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a11 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    DAT_ram_00a55a11 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_GreatRatingTopChangedEvent ---
		void ServicesNamespace_RatingService__add_GreatRatingTopChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a12 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    DAT_ram_00a55a12 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_GreatRatingTopChangedEvent ---
		void ServicesNamespace_RatingService__remove_GreatRatingTopChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    DAT_ram_00a55a13 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: add_GreatRatingSetChangedEvent ---
		void ServicesNamespace_RatingService__add_GreatRatingSetChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    DAT_ram_00a55a14 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_GreatRatingSetChangedEvent ---
		void ServicesNamespace_RatingService__remove_GreatRatingSetChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a15 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		    DAT_ram_00a55a15 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_CompetitionRatingChangedEvent ---
		void ServicesNamespace_RatingService__add_CompetitionRatingChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		    DAT_ram_00a55a16 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_RatingService__get_ServiceId(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a55a17 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_RatingEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoCompetitionRatingChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGreatRatingSetChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGreatRatingTopChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoTotalRatingChangedEvt_TypeInfo);
		    DAT_ram_00a55a17 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar2,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_RatingEvents___);
		  if (iVar2 == 0) {
		    return;
		  }
		  if (iVar2 == 1) {
		    iVar2 = *(int *)(param1 + 0x14);
		    if (iVar2 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Rating_ProtoTotalRatingChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Rating_ProtoTotalRatingChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar2 == 2) {
		    iVar2 = *(int *)(param1 + 0x18);
		    if (iVar2 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Rating_ProtoGreatRatingTopChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Rating_ProtoGreatRatingTopChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar2 == 3) {
		    iVar2 = *(int *)(param1 + 0x1c);
		    if (iVar2 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Rating_ProtoGreatRatingSetChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Rating_ProtoGreatRatingSetChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar2 == 4) {
		      return;
		    }
		    if (iVar2 != 5) {
		      uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		      uVar1 = unnamed_function_1417(uVar1);
		      System_ArgumentNullException___ctor(uVar1,0);
		      param2_00 = unnamed_function_2232
		                            (&Method_ServicesNamespace_RatingService_ServerEventHandler__);
		      func_ii_1050(uVar1,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *(int *)(param1 + 0x20);
		    if (iVar2 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Rating_ProtoCompetitionRatingChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Rating_ProtoCompetitionRatingChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: GetRating<object> ---
		int * ServicesNamespace_RatingService__GetRating_object_
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (*(int *)(param5 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param5 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		    }
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    iVar1 = unnamed_function_1417(Protocol_Rating_ProtoGetRatingCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x10) = param4;
		    *(undefined4 *)(iVar1 + 0xc) = param3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param2,iVar1,0);
		    local_8 = 0xffffffff;
		    local_c = Protocol_Rating_RatingCommands_TypeInfo;
		    local_4 = param2;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    (**(code **)((ulonglong)*(uint *)**(undefined4 **)(param5 + 0x1c) * 4))
		              (iVar1,uVar2,(uint *)**(undefined4 **)(param5 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: GetRating<__Il2CppFullySharedGenericType> ---
		uint ServicesNamespace_RatingService__GetRating___Il2CppFullySharedGenericType_
		               (int *param1,undefined4 ******param2,int param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  int param3_00;
		  int *piVar6;
		  int iVar7;
		  int param1_01;
		  undefined4 ******param2_00;
		  int iVar8;
		  undefined1 local_10 [4];
		  undefined4 *****local_c;
		  undefined4 *local_8;
		  int local_4;
		  
		  uVar2 = 0;
		  iVar4 = *(int *)(param3 + 0x1c);
		  local_c = param2;
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar4 = *(int *)(param3 + 0x1c);
		  }
		  iVar5 = *(int *)(iVar4 + 8);
		  param3_00 = *(int *)(iVar5 + 0x84);
		  iVar4 = param3_00;
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar5);
		    iVar4 = *(int *)(iVar4 + 0x84);
		  }
		  iVar5 = param1[2];
		  if (0 < iVar5) {
		    piVar6 = (int *)*param1;
		    iVar7 = param1[1];
		    uVar2 = 1;
		    iVar1 = 0;
		    do {
		      iVar8 = *(int *)(param3 + 0x1c);
		      param2_00 = param2;
		      if (-1 < *(int *)(*(int *)(iVar8 + 8) + 0x14)) {
		        param2_00 = &local_c;
		      }
		      puVar3 = (undefined4 *)
		               unnamed_function_713
		                         ((int)(local_10 + -(iVar4 + 0x17U & 0xfffffff0)) -
		                          (param3_00 + 0xfU & 0xfffffff0),param2_00,param3_00);
		      param1_01 = *(int *)(iVar8 + 8);
		      param1_00 = param1_01;
		      if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		        param1_00 = func_ii_1079(param1_01);
		        iVar8 = *(int *)(param3 + 0x1c);
		        param1_01 = *(int *)(iVar8 + 8);
		      }
		      if (-1 < *(int *)(param1_01 + 0x14)) {
		        puVar3 = (undefined4 *)*puVar3;
		      }
		      local_8 = puVar3;
		      func_ii_8296(param1_00,*(undefined4 *)(iVar8 + 0x10),local_10 + -(iVar4 + 0x17U & 0xfffffff0),
		                   (int)piVar6 + *(int *)(*piVar6 + 0x8c) * (iVar1 + iVar7) + 0x10,&local_8,&local_4
		                  );
		      if (local_4 == 0) {
		        return uVar2;
		      }
		      iVar1 = iVar1 + 1;
		      uVar2 = (uint)(iVar1 < iVar5);
		    } while (iVar1 != iVar5);
		  }
		  return uVar2;
		}
		*/

}
