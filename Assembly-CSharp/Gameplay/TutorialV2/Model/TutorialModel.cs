using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Cysharp.Threading.Tasks;
using Gameplay.Sound.Model;
using Gameplay.TutorialV2.Controller;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Main;
using Protocol.World;

namespace Gameplay.TutorialV2.Model
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	public class TutorialModel : AbstractModel
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x6AF3", Offset = "0x6AF3", VA = "0x6AF3", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialV2_Model_TutorialModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined1 *)(param1 + 0x34) = 1;
		  *(undefined4 *)(param1 + 0x14) = 2;
		  *(undefined4 *)(param1 + 0xc) = 3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x6AF4", Offset = "0x6AF4", VA = "0x6AF4")]
		public TutorialModel(IGame game, UserData user)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047A")]
		public ProtoGetUserInfoAns UserAns
		{
			[Token(Token = "0x6001956")]
			[Address(RVA = "0x6AF5", Offset = "0x6AF5", VA = "0x6AF5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x6AF6", Offset = "0x6AF6", VA = "0x6AF6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047B")]
		public ResourceSet Balance
		{
			[Token(Token = "0x6001958")]
			[Address(RVA = "0x6AF7", Offset = "0x6AF7", VA = "0x6AF7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001959")]
			[Address(RVA = "0x6AF8", Offset = "0x6AF8", VA = "0x6AF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00005850 File Offset: 0x00003A50
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047C")]
		public bool IsEnable
		{
			[Token(Token = "0x600195A")]
			[Address(RVA = "0x6AF9", Offset = "0x6AF9", VA = "0x6AF9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600195B")]
			[Address(RVA = "0x6AFA", Offset = "0x6AFA", VA = "0x6AFA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047D")]
		public string IdentityCode
		{
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x6AFB", Offset = "0x6AFB", VA = "0x6AFB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600195D")]
			[Address(RVA = "0x6AFC", Offset = "0x6AFC", VA = "0x6AFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x6AFD", Offset = "0x6AFD", VA = "0x6AFD")]
		public IEnumerable<StepActionType> GetActionsSequence()
		{
		/* --- GHIDRA: GetActionsSequence ---
		void Gameplay_TutorialV2_Model_TutorialModel__GetActionsSequence
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x6AFE", Offset = "0x6AFE", VA = "0x6AFE")]
		public void SetData(ProtoGetUserInfoAns user, ResourceSet money)
		{
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x6AFF", Offset = "0x6AFF", VA = "0x6AFF")]
		public void SetUser(UserData user)
		{
		/* --- GHIDRA: SetUser ---
		longlong Gameplay_TutorialV2_Model_TutorialModel__SetUser
		                   (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined8 param1_00;
		  longlong lVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 *puVar5;
		  uint uVar6;
		  ulonglong uVar7;
		  
		  lVar3 = 0;
		  if (DAT_ram_00a583b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    DAT_ram_00a583b4 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80edc1d9;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80edc1d9:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(in_register_20000004,param1_01),puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar4 = Core_Extensions_Dict_DictExt__TryGetArtikulOptionsDic(uVar2,param2,0);
		  if (iVar4 == 0) {
		    return 0;
		  }
		  if (((param2 == 1) || (param2 == 2)) || (param2 == 3)) {
		    uVar2 = 4;
		    puVar5 = (undefined4 *)(iVar4 + 0x10);
		  }
		  else if (param2 == 4) {
		    uVar2 = 3;
		    puVar5 = (undefined4 *)(iVar4 + 0x14);
		  }
		  else {
		    if (param2 != 5) goto code_r0x80edc255;
		    uVar2 = 3;
		    puVar5 = (undefined4 *)(iVar4 + 0x10);
		  }
		  param1_00 = func_ii_7271(*puVar5,uVar2,
		                           Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		  lVar3 = Core_Data_ModifierData__IsProcent(param1_00,0);
		code_r0x80edc255:
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  uVar7 = lVar3 * param3 >> 0x3f;
		  return (lVar3 * param3 ^ uVar7) - uVar7;
		}
		*/

		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x6B00", Offset = "0x6B00", VA = "0x6B00")]
		public long GetStoneValue(StonesTypes stone, int count)
		{
		/* --- GHIDRA: GetStoneValue ---
		void Gameplay_TutorialV2_Model_TutorialModel__GetStoneValue
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a583b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__TrySetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__get_Task__);
		    Mono_Security_ASN1__get_Item
		              (&Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__TypeInfo);
		    DAT_ram_00a583b5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__TypeInfo);
		  if (*(int *)(param2 + 0x24) != 0) {
		    param2_00 = Core_Extensions_Dict_PromotionsDicExt__GetDescription(*(int *)(param2 + 0x24),0);
		    func_ii_5553(param1_00,param2_00,
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__TrySetResult__);
		    if (*(int *)(param2 + 0x24) != 0) goto code_r0x80edc316;
		  }
		  func_ii_5553(param1_00,0,
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__TrySetResult__);
		code_r0x80edc316:
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		            (&local_c,param1_00,
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_UserInfo__get_Task__);
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/

			return 0L;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x6B01", Offset = "0x6B01", VA = "0x6B01")]
		public UniTask<UserInfo> GetUserInfo()
		{
			return default(UniTask<UserInfo>);
		}

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint PointerId;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x14")]
		public readonly PlayLists MusicTheme;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x18")]
		public ulong UserId;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x20")]
		public RepeatedField<uint> SpellIds;

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x2C")]
		public RepeatedField<ProtoGetUserIsleInfoAns.Types.IsleInformation> IsleData;

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x30")]
		public uint LimitUserNumber;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IdentityCode ---
		undefined4
		Gameplay_TutorialV2_Model_TutorialModel__set_IdentityCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4EF49EE396181174C27A1F28E9864CDA526671E55F4A2B3DE1851382ED5945B7
		              );
		    DAT_ram_00a583b3 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid
		                        (Gameplay_TutorialV2_Controller_StepActionType___TypeInfo,0xc);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__4EF49EE396181174C27A1F28E9864CDA526671E55F4A2B3DE1851382ED5945B7
		             ,0);
		  return param1_00;
		}
		*/

}
