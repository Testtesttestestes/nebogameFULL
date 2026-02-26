using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.School;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public class SchoolService : AbstractService
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x170000AA")]
		public override short ServiceId
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x5A1E", Offset = "0x5A1E", VA = "0x5A1E", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000096")]
		public event Action<ProtoLearnSpellAcceleratedEvt> LearnSpellAccelerated
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x5A1F", Offset = "0x5A1F", VA = "0x5A1F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x5A20", Offset = "0x5A20", VA = "0x5A20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000097")]
		public event Action<ProtoLearnSpellFinishedEvt> LearnSpellFinished
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x5A21", Offset = "0x5A21", VA = "0x5A21")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x5A22", Offset = "0x5A22", VA = "0x5A22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000098")]
		public event Action<ProtoLearnSpellCanceledEvt> LearnSpellCanceled
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x5A23", Offset = "0x5A23", VA = "0x5A23")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x5A24", Offset = "0x5A24", VA = "0x5A24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000099 RID: 153
		// (add) Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000099")]
		public event Action<ProtoLearnSpellStartedEvt> LearnSpellStarted
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x5A25", Offset = "0x5A25", VA = "0x5A25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x5A26", Offset = "0x5A26", VA = "0x5A26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x5A27", Offset = "0x5A27", VA = "0x5A27", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4 ServicesNamespace_SchoolService__ServerEventHandler(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a30 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoGetUserSpellsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoGetUserSpellsAns___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10823);
		    DAT_ram_00a55a30 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_School_ProtoGetUserSpellsCmd_TypeInfo);
		  uVar1 = DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_10823,1,uVar1,
		                     Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoGetUserSpellsAns___
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x5A28", Offset = "0x5A28", VA = "0x5A28")]
		public OpToken<IMessage, object> GetUserSpells()
		{
		/* --- GHIDRA: GetUserSpells ---
		undefined4
		ServicesNamespace_SchoolService__GetUserSpells
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param4;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a31 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoStartLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoStartLearnSpellAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_10827);
		    DAT_ram_00a55a31 = '\x01';
		  }
		  param4 = unnamed_function_1417(Protocol_School_ProtoStartLearnSpellCmd_TypeInfo);
		  *(undefined4 *)(param4 + 0xc) = param2;
		  uVar1 = DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_10827,2,param4,
		                     Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoStartLearnSpellAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5A29", Offset = "0x5A29", VA = "0x5A29")]
		public OpToken<IMessage, object> StartLearnSpell(uint spellId)
		{
		/* --- GHIDRA: StartLearnSpell ---
		undefined4
		ServicesNamespace_SchoolService__StartLearnSpell
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param4;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a32 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoCancelLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10825);
		    DAT_ram_00a55a32 = '\x01';
		  }
		  param4 = unnamed_function_1417(Protocol_School_ProtoCancelLearnSpellCmd_TypeInfo);
		  *(undefined4 *)(param4 + 0xc) = param2;
		  uVar1 = DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_10825,3,param4,
		                     Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoEmptyAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5A2A", Offset = "0x5A2A", VA = "0x5A2A")]
		public OpToken<IMessage, object> CancelLearnSpell(uint spellId)
		{
		/* --- GHIDRA: CancelLearnSpell ---
		undefined4
		ServicesNamespace_SchoolService__CancelLearnSpell
		          (undefined4 param1,undefined4 param2,undefined8 param3,undefined4 param4)
		
		{
		  int param4_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a33 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoAccelerateLearnSpellCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoAccelerateLearnSpellAns___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_10824);
		    DAT_ram_00a55a33 = '\x01';
		  }
		  param4_00 = unnamed_function_1417(Protocol_School_ProtoAccelerateLearnSpellCmd_TypeInfo);
		  *(undefined8 *)(param4_00 + 0x10) = param3;
		  *(undefined4 *)(param4_00 + 0x18) = param2;
		  uVar1 = DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_10824,4,param4_00,
		                     Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoAccelerateLearnSpellAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x5A2B", Offset = "0x5A2B", VA = "0x5A2B")]
		public OpToken<IMessage, object> AccelerateLearnSpell(uint spellId, ulong ownerId)
		{
		/* --- GHIDRA: AccelerateLearnSpell ---
		undefined4
		ServicesNamespace_SchoolService__AccelerateLearnSpell
		          (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param4;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a34 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoGetSchoolInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoGetSchoolInfoAns___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10826);
		    DAT_ram_00a55a34 = '\x01';
		  }
		  param4 = unnamed_function_1417(Protocol_School_ProtoGetSchoolInfoCmd_TypeInfo);
		  *(undefined8 *)(param4 + 0x10) = param2;
		  uVar1 = DefaultNamespace_SceneAppManager__TryGetSceneArgs___Il2CppFullySharedGenericType_
		                    (param1,StringLiteral_10826,5,param4,
		                     Method_ServicesNamespace_SchoolService_MageSchoolRequest_ProtoGetSchoolInfoAns___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x5A2C", Offset = "0x5A2C", VA = "0x5A2C")]
		public OpToken<IMessage, object> GetSchoolInfo(ulong ownerId)
		{
		/* --- GHIDRA: GetSchoolInfo ---
		void ServicesNamespace_SchoolService__GetSchoolInfo(int param1,undefined4 param2)
		
		{
		  *(undefined2 *)(param1 + 0x14) = 7;
		  Core_Net_AbstractService__ServerEventHandler(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600062B")]
		private OpToken<IMessage, object> MageSchoolRequest<TAns>(string cmdName, SchoolCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5A2D", Offset = "0x5A2D", VA = "0x5A2D")]
		public SchoolService()
		{
		/* --- GHIDRA: .ctor ---
		void ServicesNamespace_SchoolService___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a35 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo);
		    DAT_ram_00a55a35 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoAuchanButtonBacklightEvt__TypeInfo),
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

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_SchoolService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    DAT_ram_00a55a27 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellAccelerated ---
		void ServicesNamespace_SchoolService__add_LearnSpellAccelerated
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    DAT_ram_00a55a28 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellAccelerated ---
		void ServicesNamespace_SchoolService__remove_LearnSpellAccelerated
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    DAT_ram_00a55a29 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellFinishedEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellFinished ---
		void ServicesNamespace_SchoolService__add_LearnSpellFinished
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a2a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    DAT_ram_00a55a2a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellFinishedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellFinishedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellFinished ---
		void ServicesNamespace_SchoolService__remove_LearnSpellFinished
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a2b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    DAT_ram_00a55a2b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellCanceledEvt__TypeInfo),
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


		/* --- GHIDRA: add_LearnSpellCanceled ---
		void ServicesNamespace_SchoolService__add_LearnSpellCanceled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a2c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    DAT_ram_00a55a2c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellCanceledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellCanceledEvt__TypeInfo),
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


		/* --- GHIDRA: remove_LearnSpellCanceled ---
		void ServicesNamespace_SchoolService__remove_LearnSpellCanceled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a2d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    DAT_ram_00a55a2d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellStartedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_LearnSpellStarted ---
		void ServicesNamespace_SchoolService__add_LearnSpellStarted
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a2e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    DAT_ram_00a55a2e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoLearnSpellStartedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoLearnSpellStartedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_LearnSpellStarted ---
		void ServicesNamespace_SchoolService__remove_LearnSpellStarted
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a55a2f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_SchoolEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoLearnSpellAcceleratedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoLearnSpellCanceledEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoLearnSpellFinishedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoLearnSpellStartedEvt_TypeInfo);
		    DAT_ram_00a55a2f = '\x01';
		  }
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_SchoolEvents___);
		  iVar2 = *(int *)(param2 + 0x10);
		  if (iVar2 != 0) {
		    if (iVar2 == 1) {
		      iVar2 = *(int *)(param1 + 0x18);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_School_ProtoLearnSpellAcceleratedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_School_ProtoLearnSpellAcceleratedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 2) {
		      iVar2 = *(int *)(param1 + 0x1c);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_School_ProtoLearnSpellFinishedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_School_ProtoLearnSpellFinishedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 3) {
		      iVar2 = *(int *)(param1 + 0x20);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_School_ProtoLearnSpellCanceledEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_School_ProtoLearnSpellCanceledEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar2 != 4) {
		        uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		        uVar1 = unnamed_function_1417(uVar1);
		        System_ArgumentNullException___ctor(uVar1,0);
		        param2_00 = unnamed_function_2232
		                              (&Method_ServicesNamespace_SchoolService_ServerEventHandler__);
		        func_ii_1050(uVar1,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = *(int *)(param1 + 0x24);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_School_ProtoLearnSpellStartedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_School_ProtoLearnSpellStartedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MageSchoolRequest<__Il2CppFullySharedGenericType> ---
		int ServicesNamespace_SchoolService__MageSchoolRequest___Il2CppFullySharedGenericType_(int param1)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int param1_01;
		  
		  puVar2 = *(undefined4 **)(param1 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param1);
		    puVar2 = *(undefined4 **)(param1 + 0x1c);
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar1 = 0;
		  uVar3 = func_ii_2734(uVar3,0);
		  param1_00 = UnityEngine_ScriptableObject___ctor(uVar3,0);
		  param1_01 = *(int *)(*(int *)(param1 + 0x1c) + 4);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  if ((param1_00 != 0) && (iVar1 = func_ii_1082(param1_00,param1_01), iVar1 == 0)) {
		    System_Activator__CreateInstance(param1_00,param1_01);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return iVar1;
		}
		*/

}
