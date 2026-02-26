using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Clans.Model
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	public class ClansModel : AbstractModel
	{
		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600408F RID: 16527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CBB")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600408F")]
			[Address(RVA = "0x8F46", Offset = "0x8F46", VA = "0x8F46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBC")]
		public ulong OwnClanId
		{
			[Token(Token = "0x6004090")]
			[Address(RVA = "0x8F47", Offset = "0x8F47", VA = "0x8F47")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004091")]
			[Address(RVA = "0x8F48", Offset = "0x8F48", VA = "0x8F48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBD")]
		public TreasuryData Treasury
		{
			[Token(Token = "0x6004092")]
			[Address(RVA = "0x8F49", Offset = "0x8F49", VA = "0x8F49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004093")]
			[Address(RVA = "0x8F4A", Offset = "0x8F4A", VA = "0x8F4A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004095 RID: 16533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBE")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation ClanIsleInfo
		{
			[Token(Token = "0x6004094")]
			[Address(RVA = "0x8F4B", Offset = "0x8F4B", VA = "0x8F4B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004095")]
			[Address(RVA = "0x8F4C", Offset = "0x8F4C", VA = "0x8F4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004097 RID: 16535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBF")]
		public UserData GolemUserData
		{
			[Token(Token = "0x6004096")]
			[Address(RVA = "0x8F4D", Offset = "0x8F4D", VA = "0x8F4D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004097")]
			[Address(RVA = "0x8F4E", Offset = "0x8F4E", VA = "0x8F4E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x17000CC0")]
		public bool IsHead
		{
			[Token(Token = "0x6004098")]
			[Address(RVA = "0x8F4F", Offset = "0x8F4F", VA = "0x8F4F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x8F50", Offset = "0x8F50", VA = "0x8F50")]
		public ClansModel(UserData user)
		{
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x8F51", Offset = "0x8F51", VA = "0x8F51")]
		public void SetClanId(ulong clanId)
		{
		/* --- GHIDRA: SetClanId ---
		void Gameplay_Clans_Model_ClansModel__SetClanId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  iVar1 = *(int *)(param1 + 8);
		  *(undefined4 *)(iVar1 + 0x68) = 0;
		  *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x40) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x8F52", Offset = "0x8F52", VA = "0x8F52")]
		public void DissociateClanFromUser()
		{
		/* --- GHIDRA: DissociateClanFromUser ---
		void Gameplay_Clans_Model_ClansModel__DissociateClanFromUser
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5773e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a5773e = '\x01';
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  *(undefined8 *)(param1 + 0x10) = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  if (*(int *)(param2 + 0x20) != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		          goto code_r0x80dd277e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80dd277e:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    uVar5 = *(undefined4 *)(param2 + 0x20);
		    piVar3 = *(int **)(iVar4 + 0x14);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dd280a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80dd280a:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,uVar5,puVar2[1]);
		    *(undefined4 *)(param1 + 0x20) = uVar5;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x8F53", Offset = "0x8F53", VA = "0x8F53")]
		public void SetOwnClanIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x8F54", Offset = "0x8F54", VA = "0x8F54")]
		public void UpdateOwnClanIsleInfo(ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
		/* --- GHIDRA: UpdateOwnClanIsleInfo ---
		void Gameplay_Clans_Model_ClansModel__UpdateOwnClanIsleInfo(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5773f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Model_TreasuryData_TypeInfo);
		    DAT_ram_00a5773f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Clans_Model_TreasuryData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param2 + 0x10);
		  *(int *)(param1 + 0x18) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x8F55", Offset = "0x8F55", VA = "0x8F55")]
		public void CreateTreasury(ProtoGetClanTreasuryAns msg)
		{
		/* --- GHIDRA: CreateTreasury ---
		uint Gameplay_Clans_Model_ClansModel__CreateTreasury
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  
		  *param2 = 0;
		  lVar1 = *(longlong *)(param1 + 0x10);
		  if (lVar1 != 0) {
		    *param2 = *(undefined4 *)(param1 + 0x1c);
		  }
		  return (uint)(lVar1 != 0);
		}
		*/

		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x8F56", Offset = "0x8F56", VA = "0x8F56")]
		public bool TryGetOwnClanIsleInfo(out ProtoGetIsleInfoAns.Types.ClanIsleInformation info)
		{
		/* --- GHIDRA: TryGetOwnClanIsleInfo ---
		undefined4
		Gameplay_Clans_Model_ClansModel__TryGetOwnClanIsleInfo
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  uint uVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57740 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BuildingInfo__GetEnumerator__);
		    DAT_ram_00a57740 = '\x01';
		  }
		  if (*(longlong *)(param1 + 0x10) != 0) {
		    local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                               (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0xc),
		                                Method_Google_Protobuf_Collections_RepeatedField_BuildingInfo__GetEnumerator__
		                               );
		    local_c = 0;
		    local_8 = &local_4;
		    do {
		      piVar4 = local_4;
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80dd29d1;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar1 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80dd2a21:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dd2b2a:
		        iVar6 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar6 == iVar3) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar3 = *piVar4;
		          iVar6 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_c = iVar3;
		          import::env::invoke_v(0x123);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          uVar2 = 0;
		          if (iVar8 != 1) goto code_r0x80dd2b7b;
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x354,&local_c);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80dd29d1:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		      piVar4 = local_4;
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) goto code_r0x80dd2a21;
		      if (iVar3 == 0) {
		        iVar3 = 0;
		        iVar6 = 2;
		        uVar2 = 0;
		        goto code_r0x80dd2b7b;
		      }
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		          if (System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo == *piVar7) {
		            puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80dd2ac4;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar1 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80dd2b22:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dd2b2a;
		      }
		code_r0x80dd2ac4:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) goto code_r0x80dd2b22;
		    } while (*(int *)(iVar3 + 0xc) != param2);
		    *param3 = iVar3;
		    uVar2 = 1;
		    iVar6 = 5;
		    iVar3 = 0;
		code_r0x80dd2b7b:
		    piVar4 = local_4;
		    if (local_4 != (int *)0x0) {
		      uVar9 = 0;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		            puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80dd2bf3;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dd2bf3:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		    }
		    if (iVar3 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar6 != 0) {
		      if (iVar6 == 1) {
		        return uVar2;
		      }
		      if (iVar6 != 2) {
		        return uVar2;
		      }
		    }
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x8F57", Offset = "0x8F57", VA = "0x8F57")]
		public bool TryGetBuilding(ClanBuildingTypes buildingType, out BuildingInfo buildingInfo)
		{
		/* --- GHIDRA: TryGetBuilding ---
		int Gameplay_Clans_Model_ClansModel__TryGetBuilding(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  int param2_00;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a57741 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RestrictionInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RestrictionInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RestrictionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21197);
		    Mono_Security_ASN1__get_Item(&StringLiteral_560);
		    DAT_ram_00a57741 = '\x01';
		  }
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar1,StringLiteral_21197,0);
		  uVar1 = System_Data_DataSet__ReadXmlSchema(iVar2,2,*(int *)(iVar2 + 8) + -2,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_560;
		  iVar2 = System_UriBuilder___ctor(uVar1,iVar2,1,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RestrictionInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RestrictionInfo___ctor__);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar5 * 4 + 0x10);
		      uVar1 = System_Data_DataSet__ReadXmlSchema(iVar3,1,*(int *)(iVar3 + 8) + -1,0);
		      iVar3 = System_Net_WebConnection__ReadLine(uVar1,0x2c,0,0);
		      param2_00 = unnamed_function_1417(Protocol_Common_RestrictionInfo_TypeInfo);
		      uVar1 = func_ii_8697(*(undefined4 *)(iVar3 + 0x10),0);
		      *(undefined4 *)(param2_00 + 0xc) = uVar1;
		      iVar3 = func_ii_8697(*(undefined4 *)(iVar3 + 0x14),0);
		      *(longlong *)(param2_00 + 0x10) = (longlong)iVar3;
		      iVar3 = Method_System_Collections_Generic_List_RestrictionInfo__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar4 = *(uint *)(param1_00 + 0xc);
		      if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar2 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x8F58", Offset = "0x8F58", VA = "0x8F58")]
		public List<RestrictionInfo> GetClanCreationRestrictions()
		{
			return null;
		}

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_GolemUserData ---
		uint Gameplay_Clans_Model_ClansModel__set_GolemUserData(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  
		  if (*(longlong *)(param1 + 0x10) != 0) {
		    lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1 + 8),0);
		    return (uint)(lVar1 == *(longlong *)(*(int *)(*(int *)(param1 + 0x1c) + 0x2c) + 0x10));
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_IsHead ---
		void Gameplay_Clans_Model_ClansModel__get_IsHead(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5773d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5773d = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80dd265a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd265a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  return;
		}
		*/

}
