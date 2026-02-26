using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using Protocol.Themeduel;
using Utils;

namespace Gameplay.ThemeDuelState.Model
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	public class ThemeDuelStateModel : AbstractModel
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x1700053C")]
		public bool HasCurrentThemeDuel
		{
			[Token(Token = "0x6001D4A")]
			[Address(RVA = "0x6EC9", Offset = "0x6EC9", VA = "0x6EC9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053D")]
		public ThemeDuelDic CurrentThemeDuel
		{
			[Token(Token = "0x6001D4B")]
			[Address(RVA = "0x6ECA", Offset = "0x6ECA", VA = "0x6ECA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x1700053E")]
		public ThemeRatingTypes ThemeRatingType
		{
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x6ECB", Offset = "0x6ECB", VA = "0x6ECB")]
			get
			{
				return ThemeRatingTypes.Unknown;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		public BackTime DuelBackTime
		{
			[Token(Token = "0x6001D4D")]
			[Address(RVA = "0x6ECC", Offset = "0x6ECC", VA = "0x6ECC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D4E")]
			[Address(RVA = "0x6ECD", Offset = "0x6ECD", VA = "0x6ECD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000540")]
		public BackTime EventBackTime
		{
			[Token(Token = "0x6001D4F")]
			[Address(RVA = "0x6ECE", Offset = "0x6ECE", VA = "0x6ECE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D50")]
			[Address(RVA = "0x6ECF", Offset = "0x6ECF", VA = "0x6ECF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x17000541")]
		public long EventBalance
		{
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0x6ED0", Offset = "0x6ED0", VA = "0x6ED0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x17000542")]
		public int EventEntryAttempt
		{
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0x6ED1", Offset = "0x6ED1", VA = "0x6ED1")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000543")]
		public ResourceSet Price
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0x6ED2", Offset = "0x6ED2", VA = "0x6ED2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x6ED3", Offset = "0x6ED3", VA = "0x6ED3")]
		public ThemeDuelStateModel(UserData user, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  uint in_register_20000014;
		  undefined8 uVar1;
		  float param2_00;
		  float param2_01;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined8 uVar5;
		  uint uVar6;
		  float4 local_18;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5858b == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4601);
		    DAT_ram_00a5858b = '\x01';
		  }
		  local_14 = 0;
		  if (param2 != 0) {
		    uVar5 = *(undefined8 *)(param2 + 0x20);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(uVar5,0);
		    uVar5 = *(undefined8 *)(param2 + 0x18);
		    param2_01 = Utils_StringUtils___cctor(uVar5,0);
		    in_register_20000004 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    if (*(longlong *)(param2 + 0x10) != 0) {
		      uVar6 = 0;
		      param1_00 = *(int **)(param1 + 0xc);
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x178);
		            goto code_r0x80f08d48;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f08d48:
		      uVar5 = CONCAT44(in_register_20000004,param1_00);
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(uVar5,CONCAT44(in_register_20000014,puVar2[1]));
		      in_register_20000004 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar5 = *(undefined8 *)(param2 + 0x10);
		      iVar4 = Core_Extensions_Dict_DictExt__TryGetGameEventDic(uVar3,uVar5,&local_14,0);
		      in_register_20000014 = (uint)((ulonglong)uVar5 >> 0x20);
		      if (iVar4 == 0) {
		        local_10 = *(undefined8 *)(param2 + 0x10);
		        uVar3 = func_ii_1081(DAT_ram_00a66968,&local_10);
		        uVar3 = func_ii_4419(StringLiteral_4601,uVar3,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7109(uVar3,0);
		      }
		    }
		    if ((local_14 != 0) && ((0.0 < param2_00 || (0.0 < param2_01)))) {
		      local_18 = *(float4 *)(*(int *)(param1 + 0x30) + 8);
		      iVar4 = System_Single__Equals(&local_18,param2_00,0);
		      if (iVar4 == 0) {
		        uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		        Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,param2_00,0);
		        *(undefined4 *)(param1 + 0x30) = uVar3;
		      }
		      local_18 = *(float4 *)(*(int *)(param1 + 0x34) + 8);
		      iVar4 = System_Single__Equals(&local_18,param2_01,0);
		      if (iVar4 == 0) {
		        uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		        Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,param2_01,0);
		        *(undefined4 *)(param1 + 0x34) = uVar3;
		      }
		      if ((*(int *)(param1 + 0x10) != 0) &&
		         (*(longlong *)(*(int *)(param1 + 0x10) + 0x10) == *(longlong *)(local_14 + 0x10))) {
		        return;
		      }
		      *(int *)(param1 + 0x10) = local_14;
		      iVar4 = *(int *)(param3 + 0x18);
		      if (iVar4 != 0) {
		        uVar5 = CONCAT44(in_register_20000004,*(undefined4 *)(iVar4 + 0x20));
		        uVar1 = CONCAT44(in_register_20000014,local_14);
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (uVar5,uVar1,*(undefined4 *)(iVar4 + 0x14));
		        in_register_20000014 = (uint)((ulonglong)uVar1 >> 0x20);
		        in_register_20000004 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      }
		      if (DAT_ram_00a5858c == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_HasValue__);
		        DAT_ram_00a5858c = '\x01';
		      }
		      if ((*(char *)(param1 + 0x18) == '\0') || (*(longlong *)(param1 + 0x20) != 0)) {
		        local_8 = 0;
		        local_10 = 0;
		        in_register_20000014 = 0;
		        Core_Log_Files_FileDownloadLogger__LogDownload
		                  (&local_10,0,Method_System_Nullable_long___ctor__);
		        *(undefined8 *)(param1 + 0x20) = local_8;
		        *(undefined8 *)(param1 + 0x18) = local_10;
		        iVar4 = *(int *)(param3 + 0x20);
		        if (iVar4 != 0) {
		          uVar5 = CONCAT44(in_register_20000004,*(undefined4 *)(iVar4 + 0x20));
		          in_register_20000014 = 0;
		          (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                    (uVar5,0,*(undefined4 *)(iVar4 + 0x14));
		          in_register_20000004 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        }
		      }
		      if (DAT_ram_00a5858d == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		        DAT_ram_00a5858d = '\x01';
		      }
		      if (*(ulonglong *)(param1 + 0x28) < 0x100000000 && (*(ulonglong *)(param1 + 0x28) & 0xff) != 0
		         ) {
		        return;
		      }
		      local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor(&local_10,0,Method_System_Nullable_int___ctor__);
		      *(undefined8 *)(param1 + 0x28) = local_10;
		      iVar4 = *(int *)(param3 + 0x24);
		      if (iVar4 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (CONCAT44(in_register_20000004,*(undefined4 *)(iVar4 + 0x20)),
		                 (ulonglong)in_register_20000014 << 0x20,*(undefined4 *)(iVar4 + 0x14));
		      return;
		    }
		  }
		  uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,0.0,0);
		  *(undefined4 *)(param1 + 0x30) = uVar3;
		  uVar3 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar3,0.0,0);
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x34) = uVar3;
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x28) = 0;
		  if (*(int *)(param1 + 0x10) != 0) {
		    *(undefined4 *)(param1 + 0x10) = 0;
		    iVar4 = *(int *)(param3 + 0x18);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (CONCAT44(in_register_20000004,*(undefined4 *)(iVar4 + 0x20)),
		                 (ulonglong)in_register_20000014 << 0x20,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x6ED4", Offset = "0x6ED4", VA = "0x6ED4")]
		public void SetCurrentThemeDuel(ThemeduelEventInfo currentState, ThemeDuelStateEvents events)
		{
		/* --- GHIDRA: SetCurrentThemeDuel ---
		void Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__SetCurrentThemeDuel
		               (int param1,longlong param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5858c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_HasValue__);
		    DAT_ram_00a5858c = '\x01';
		  }
		  if ((*(char *)(param1 + 0x18) == '\0') || (*(longlong *)(param1 + 0x20) != param2)) {
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,param2,Method_System_Nullable_long___ctor__);
		    *(undefined8 *)(param1 + 0x20) = local_8;
		    *(undefined8 *)(param1 + 0x18) = local_10;
		    iVar1 = *(int *)(param3 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x6ED5", Offset = "0x6ED5", VA = "0x6ED5")]
		public void SetEventBalance(long value, ThemeDuelStateEvents events)
		{
		/* --- GHIDRA: SetEventBalance ---
		void Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__SetEventBalance
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5858d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    DAT_ram_00a5858d = '\x01';
		  }
		  if ((*(ulonglong *)(param1 + 0x28) & 0xff) == 0 ||
		      (int)(*(ulonglong *)(param1 + 0x28) >> 0x20) != param2) {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_8,param2,Method_System_Nullable_int___ctor__);
		    *(undefined8 *)(param1 + 0x28) = local_8;
		    iVar1 = *(int *)(param3 + 0x24);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x6ED6", Offset = "0x6ED6", VA = "0x6ED6")]
		public void SetEventEntryAttempt(int value, ThemeDuelStateEvents events)
		{
		/* --- GHIDRA: SetEventEntryAttempt ---
		uint Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__SetEventEntryAttempt
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  float fVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if (0.0 < fVar1) {
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		  }
		  else {
		    uVar3 = 0;
		  }
		  *param2 = uVar3;
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if (0.0 < fVar1) {
		    uVar2 = (uint)(*(int *)(param1 + 0x10) != 0);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x6ED7", Offset = "0x6ED7", VA = "0x6ED7")]
		public bool TryGetCurrentDuel(out ThemeDuelDic dic)
		{
		/* --- GHIDRA: TryGetCurrentDuel ---
		void Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__TryGetCurrentDuel(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5858e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		    DAT_ram_00a5858e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0xC")]
		private readonly IGame _game;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x10")]
		private ThemeDuelDic _currentThemeDuel;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x18")]
		private long? _balance;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x28")]
		private int? _entryAttempt;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_HasCurrentThemeDuel ---
		undefined4
		Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		          (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if (0.0 < fVar1) {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_CurrentThemeDuel ---
		undefined4
		Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_CurrentThemeDuel
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  
		  uVar1 = 0;
		  fVar2 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if ((0.0 < fVar2) && (*(int *)(param1 + 0x10) != 0)) {
		    func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		    uVar1 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x10);
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_EventBackTime ---
		undefined8
		Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__set_EventBackTime(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58587 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    DAT_ram_00a58587 = '\x01';
		  }
		  return *(undefined8 *)(param1 + 0x20);
		}
		*/


		/* --- GHIDRA: get_EventBalance ---
		undefined4
		Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventBalance(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58588 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		    DAT_ram_00a58588 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x2c);
		}
		*/


		/* --- GHIDRA: get_EventEntryAttempt ---
		undefined4
		Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_EventEntryAttempt
		          (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  float fVar1;
		  int *param1_00;
		  uint *puVar2;
		  uint uVar3;
		  int *piVar4;
		  uint uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  uint uVar14;
		  int *piVar15;
		  
		  uVar7 = 0;
		  if (DAT_ram_00a58589 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_GroupBy_CurrentLevelCountPrice__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_CurrentLevelCountPrice__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_IGrouping_ulong__CurrentLevelCountPrice___ulong___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_CurrentLevelCountPrice___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_IGrouping_ulong__CurrentLevelCountPrice____
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CurrentLevelCountPrice___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_IGrouping_ulong__CurrentLevelCountPrice____);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_ulong__CurrentLevelCountPrice___ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CurrentLevelCountPrice__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_ulong__CurrentLevelCountPrice___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CurrentLevelCountPrice__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Linq_IGrouping_ulong__CurrentLevelCountPrice__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IGrouping_ulong__CurrentLevelCountPrice___get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IGrouping_ulong__CurrentLevelCountPrice___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_3__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0__get_Price_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0__get_Price_b__4__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		    DAT_ram_00a58589 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0_TypeInfo
		                        );
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		  if ((0.0 < fVar1) && (*(int *)(param1 + 0x10) != 0)) {
		    func_ii_7103(*(undefined4 *)(param1 + 0x34),0);
		    uVar7 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x38);
		    if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c)
		    ;
		    iVar9 = puVar8[1];
		    if (iVar9 == 0) {
		      if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		        puVar8 = *(undefined4 **)
		                  (Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c);
		      }
		      uVar10 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_CurrentLevelCountPrice__ulong__TypeInfo);
		      func_ii_7542(iVar9,uVar10,
		                   Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_0__
		                   ,0);
		      *(int *)(*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c) + 4)
		           = iVar9;
		    }
		    uVar7 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (uVar7,iVar9,
		                       Method_System_Linq_Enumerable_GroupBy_CurrentLevelCountPrice__ulong___);
		    if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c)
		    ;
		    iVar9 = puVar8[2];
		    if (iVar9 == 0) {
		      if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		        puVar8 = *(undefined4 **)
		                  (Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c);
		      }
		      uVar10 = *puVar8;
		      iVar9 = unnamed_function_1417
		                        (System_Func_IGrouping_ulong__CurrentLevelCountPrice___ulong__TypeInfo);
		      func_ii_7542(iVar9,uVar10,
		                   Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_1__
		                   ,0);
		      *(int *)(*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c) + 8)
		           = iVar9;
		    }
		    uVar7 = System_Func_object__ulong____ctor
		                      (uVar7,iVar9,
		                       Method_System_Linq_Enumerable_OrderBy_IGrouping_ulong__CurrentLevelCountPrice___ulong___
		                      );
		    iVar9 = System_Linq_Enumerable__Select_object__object_
		                      (uVar7,
		                       Method_System_Linq_Enumerable_ToList_IGrouping_ulong__CurrentLevelCountPrice____
		                      );
		    uVar7 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 8),0);
		    *(undefined4 *)(param2_00 + 8) = uVar7;
		    uVar7 = unnamed_function_1417
		                      (System_Func_IGrouping_ulong__CurrentLevelCountPrice___bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar7,param2_00,
		               Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0__get_Price_b__2__
		               ,0);
		    param1_00 = (int *)UI_SimpleIconValue__set_Value
		                                 (iVar9,uVar7,
		                                  Method_System_Linq_Enumerable_SingleOrDefault_IGrouping_ulong__CurrentLevelCountPrice____
		                                 );
		    if (param1_00 == (int *)0x0) {
		      iVar6 = 0;
		      while (iVar6 < *(int *)(iVar9 + 0xc)) {
		        param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                     (iVar9,iVar6,
		                                      Method_System_Collections_Generic_List_IGrouping_ulong__CurrentLevelCountPrice___get_Item__
		                                     );
		        iVar13 = *param1_00;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          uVar5 = 0;
		          do {
		            piVar4 = (int *)(*(int *)(iVar13 + 0x58) + uVar5 * 8);
		            if (System_Linq_IGrouping_ulong__CurrentLevelCountPrice__TypeInfo == *piVar4) {
		              puVar2 = (uint *)(iVar13 + piVar4[1] * 8 + 0xc0);
		              goto code_r0x80f0891c;
		            }
		            uVar5 = uVar5 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar5);
		        }
		        puVar2 = (uint *)func_ii_1080(param1_00,
		                                      System_Linq_IGrouping_ulong__CurrentLevelCountPrice__TypeInfo,
		                                      0);
		code_r0x80f0891c:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		        uVar5 = 0xffffffff;
		        iVar13 = iVar6 + 1;
		        if (iVar13 < *(int *)(iVar9 + 0xc)) {
		          piVar4 = (int *)System_Linq_Enumerable__ToList_object_
		                                    (iVar9,iVar13,
		                                     Method_System_Collections_Generic_List_IGrouping_ulong__CurrentLevelCountPrice___get_Item__
		                                    );
		          iVar11 = *piVar4;
		          if (*(ushort *)(iVar11 + 0xb6) != 0) {
		            uVar5 = 0;
		            do {
		              piVar15 = (int *)(*(int *)(iVar11 + 0x58) + uVar5 * 8);
		              if (System_Linq_IGrouping_ulong__CurrentLevelCountPrice__TypeInfo == *piVar15) {
		                puVar2 = (uint *)(iVar11 + piVar15[1] * 8 + 0xc0);
		                goto code_r0x80f089ba;
		              }
		              uVar5 = uVar5 + 1;
		            } while (*(ushort *)(iVar11 + 0xb6) != uVar5);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar4,
		                                        System_Linq_IGrouping_ulong__CurrentLevelCountPrice__TypeInfo
		                                        ,0);
		code_r0x80f089ba:
		          uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		        }
		        uVar14 = *(uint *)(param2_00 + 8);
		        if ((iVar6 == 0 && uVar14 < uVar3) ||
		           ((iVar6 = iVar13, uVar3 <= uVar14 && (uVar14 < uVar5)))) goto code_r0x80f089f9;
		      }
		      param1_00 = (int *)0x0;
		    }
		code_r0x80f089f9:
		    if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c)
		    ;
		    iVar9 = puVar8[3];
		    if (iVar9 == 0) {
		      if (*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo);
		        puVar8 = *(undefined4 **)
		                  (Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c);
		      }
		      uVar7 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_CurrentLevelCountPrice__ulong__TypeInfo);
		      func_ii_7542(iVar9,uVar7,
		                   Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__get_Price_b__23_3__
		                   ,0);
		      *(int *)(*(int *)(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c_TypeInfo + 0x5c) + 0xc
		              ) = iVar9;
		    }
		    uVar7 = System_Func_object__ulong____ctor
		                      (param1_00,iVar9,
		                       Method_System_Linq_Enumerable_OrderBy_CurrentLevelCountPrice__ulong___);
		    iVar9 = System_Linq_Enumerable__Select_object__object_
		                      (uVar7,Method_System_Linq_Enumerable_ToList_CurrentLevelCountPrice___);
		    if (DAT_ram_00a58588 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		      DAT_ram_00a58588 = '\x01';
		    }
		    *(int *)(param2_00 + 0xc) = *(int *)(param1 + 0x2c) + 1;
		    uVar7 = unnamed_function_1417(System_Func_CurrentLevelCountPrice__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar7,param2_00,
		               Method_Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___c__DisplayClass23_0__get_Price_b__4__
		               ,0);
		    iVar6 = UI_SimpleIconValue__set_Value
		                      (iVar9,uVar7,
		                       Method_System_Linq_Enumerable_SingleOrDefault_CurrentLevelCountPrice___);
		    if (iVar6 == 0) {
		      if (*(int *)(iVar9 + 0xc) < 1) {
		        return 0;
		      }
		      iVar6 = System_Linq_Enumerable__ToList_object_
		                        (iVar9,0,
		                         Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Item__);
		      iVar11 = *(int *)(iVar6 + 0x18);
		      iVar13 = 0x7fffffff;
		      if (1 < *(int *)(iVar9 + 0xc)) {
		        iVar13 = System_Linq_Enumerable__ToList_object_
		                           (iVar9,1,
		                            Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Item__
		                           );
		        iVar13 = *(int *)(iVar13 + 0x18);
		      }
		      if ((iVar11 <= *(int *)(param2_00 + 0xc)) && (iVar13 <= *(int *)(param2_00 + 0xc))) {
		        iVar13 = 1;
		        do {
		          if (*(int *)(iVar9 + 0xc) <= iVar13) {
		            return 0;
		          }
		          iVar6 = System_Linq_Enumerable__ToList_object_
		                            (iVar9,iVar13,
		                             Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Item__
		                            );
		          iVar12 = *(int *)(iVar6 + 0x18);
		          iVar11 = 0x7fffffff;
		          iVar13 = iVar13 + 1;
		          if (iVar13 < *(int *)(iVar9 + 0xc)) {
		            iVar11 = System_Linq_Enumerable__ToList_object_
		                               (iVar9,iVar13,
		                                Method_System_Collections_Generic_List_CurrentLevelCountPrice__get_Item__
		                               );
		            iVar11 = *(int *)(iVar11 + 0x18);
		          }
		        } while ((*(int *)(param2_00 + 0xc) < iVar12) || (iVar11 <= *(int *)(param2_00 + 0xc)));
		      }
		    }
		    uVar7 = *(undefined4 *)(iVar6 + 0x20);
		  }
		  return uVar7;
		}
		*/


		/* --- GHIDRA: get_Price ---
		void Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_Price
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5858a == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a5858a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/

}
