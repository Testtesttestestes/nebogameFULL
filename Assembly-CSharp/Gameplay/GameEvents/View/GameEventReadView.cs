using System;
using AssetContent;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class GameEventReadView : MonoBehaviourWithStates<GameEventReadView.GameEventReadViewStates>
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BB")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x6002D8A")]
			[Address(RVA = "0x7E08", Offset = "0x7E08", VA = "0x7E08")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BC")]
		public Button TakeRewardButton
		{
			[Token(Token = "0x6002D8B")]
			[Address(RVA = "0x7E09", Offset = "0x7E09", VA = "0x7E09")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BD")]
		public ActionsOnEventBox ActionsBox
		{
			[Token(Token = "0x6002D8C")]
			[Address(RVA = "0x7E0A", Offset = "0x7E0A", VA = "0x7E0A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BE")]
		public ScrollRect ContentScrollRect
		{
			[Token(Token = "0x6002D8D")]
			[Address(RVA = "0x7E0B", Offset = "0x7E0B", VA = "0x7E0B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BF")]
		public MonoPointerClickHandler BackgroundClickHandler
		{
			[Token(Token = "0x6002D8E")]
			[Address(RVA = "0x7E0C", Offset = "0x7E0C", VA = "0x7E0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C0")]
		public GameEventData Data
		{
			[Token(Token = "0x6002D8F")]
			[Address(RVA = "0x7E0D", Offset = "0x7E0D", VA = "0x7E0D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D90")]
			[Address(RVA = "0x7E0E", Offset = "0x7E0E", VA = "0x7E0E")]
			set
			{
			}
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x7E0F", Offset = "0x7E0F", VA = "0x7E0F")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GameEvents_View_GameEventReadView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57487 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates___ctor__
		              );
		    DAT_ram_00a57487 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_GameEventReadView_GameEventReadViewStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x7E10", Offset = "0x7E10", VA = "0x7E10")]
		public GameEventReadView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_GameEvents_View_GameEventReadView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57488 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12619);
		    DAT_ram_00a57488 = '\x01';
		  }
		  return StringLiteral_12619;
		}
		*/

		}

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _evtTypeDBGField;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descriptionField;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _viewOwner;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _takeRewardButton;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActionsOnEventBox _actionsBox;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameRawImage _backgroundLoader;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MonoPointerClickHandler _backgroundClickHandler;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x40")]
		private GameEventData _data;

		// Token: 0x02000779 RID: 1913
		[Token(Token = "0x2000779")]
		public enum GameEventReadViewStates
		{
			// Token: 0x040018F4 RID: 6388
			[Token(Token = "0x40018F4")]
			UNKNOWN_STATE,
			// Token: 0x040018F5 RID: 6389
			[Token(Token = "0x40018F5")]
			TAKE_REWARD_STATE,
			// Token: 0x040018F6 RID: 6390
			[Token(Token = "0x40018F6")]
			WORK_WHIT_DROP_STATE,
			// Token: 0x040018F7 RID: 6391
			[Token(Token = "0x40018F7")]
			READ_STATE
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GameEvents_View_GameEventReadView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x40)) {
		    *(int *)(param1 + 0x40) = param2;
		    Gameplay_GameEvents_View_GameEventReadView__set_Data(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GameEvents_View_GameEventReadView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57486 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_AbstractTag_TagViewHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7537);
		    DAT_ram_00a57486 = '\x01';
		  }
		  if (*(int *)(param1 + 0x40) != 0) {
		    uVar1 = Core_Extensions_Dict_EventTypeDicExt__GetTitle
		                      (*(undefined4 *)(*(int *)(param1 + 0x40) + 0x20),0);
		    uVar5 = *(undefined4 *)(param1 + 0x40);
		    iVar2 = unnamed_function_1417
		                      (Gameplay_GameEvents_Model_Tags_AbstractTag_TagViewHandler_TypeInfo);
		    *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(param1 + 0x24);
		    uVar1 = Gameplay_GameEvents_Model_GameEventData__TryGetInfoPageURL(uVar1,uVar5,iVar2,param1);
		    iVar2 = **(int **)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    iVar2 = System_Collections_Generic_Dictionary_Enumerator_ulong__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x40) + 0x1c),
		                       *(undefined4 *)(*(int *)(*(int *)(param1 + 0x40) + 0x18) + 0x44),0);
		    if (iVar2 == 0) {
		      iVar2 = *(int *)(*(int *)(param1 + 0x40) + 0x34);
		      iVar6 = *(int *)(param1 + 0x30);
		      if (iVar2 != *(int *)(iVar6 + 0x1c)) {
		        *(int *)(iVar6 + 0x1c) = iVar2;
		        Gameplay_GameEvents_View_ActionsOnEventBox__set_ActionsOnEvent(iVar6,param1);
		      }
		    }
		    iVar6 = *(int *)(*(int *)(param1 + 0x40) + 0x10);
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(iVar6 + 0x10),0);
		    if ((iVar2 == 0) &&
		       (iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                          (*(undefined4 *)(iVar6 + 0x14),0), iVar2 == 0)) {
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		                (*(undefined4 *)(param1 + 0x34),*(undefined4 *)(iVar6 + 0x10),0);
		    }
		    else {
		      iVar6 = *(int *)(*(int *)(param1 + 0x40) + 0x10);
		      iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (*(undefined4 *)(iVar6 + 8),0);
		      if ((iVar2 == 0) &&
		         (iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                            (*(undefined4 *)(iVar6 + 0xc),0), iVar2 == 0)) {
		        AssetContent_GameRawImage__get_AssetPath
		                  (*(undefined4 *)(param1 + 0x34),*(undefined4 *)(iVar6 + 8),0);
		      }
		      else {
		        local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x40) + 0x20) + 0xc);
		        uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		        local_10 = *(undefined8 *)(*(int *)(*(int *)(param1 + 0x40) + 0x24) + 0x10);
		        uVar5 = func_ii_1081(DAT_ram_00a66968,&local_10);
		        uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                          (StringLiteral_7537,uVar1,uVar5,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7109(uVar1,0);
		      }
		    }
		    local_10 = CONCAT44(local_10._4_4_,
		                        *(undefined4 *)(*(int *)(*(int *)(param1 + 0x40) + 0x24) + 0x24));
		    iVar2 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_10,1,0);
		    if ((iVar2 == 0) && (*(int *)(*(int *)(param1 + 0x40) + 0x3c) != 0)) {
		      iVar2 = *(int *)(*(int *)(param1 + 0x40) + 0x18);
		      if (DAT_ram_00a574be == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		        DAT_ram_00a574be = '\x01';
		      }
		      piVar7 = *(int **)(iVar2 + 0xc);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0x220);
		            goto code_r0x80d8d905;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80d8d905:
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      uVar4 = 0;
		      uVar1 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0x3c);
		      piVar7 = *(int **)(iVar2 + 0x18);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0xd0);
		            goto code_r0x80d8d994;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Sound_Control_IGameAudio_TypeInfo,2);
		code_r0x80d8d994:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar1,puVar3[1]);
		    }
		    uVar4 = Gameplay_GameEvents_Model_GameEventData__TryResetArtifactFromRewardCache
		                      (*(undefined4 *)(param1 + 0x40),&local_10,param1);
		    iVar2 = **(int **)(param1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x188) * 4))
		              (*(int **)(param1 + 0x34),uVar4,*(undefined4 *)(iVar2 + 0x18c));
		    iVar2 = **(int **)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x188) * 4))
		              (*(int **)(param1 + 0x20),uVar4 ^ 1,*(undefined4 *)(iVar2 + 0x18c));
		  }
		  return;
		}
		*/

}
