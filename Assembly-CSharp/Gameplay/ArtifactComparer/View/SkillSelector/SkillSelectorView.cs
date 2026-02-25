using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ArtifactComparer.View.SkillSelector
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	public class SkillSelectorView : MonoBehaviour
	{
		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x0000EB38 File Offset: 0x0000CD38
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103C")]
		public bool IsInitialized
		{
			[Token(Token = "0x6005030")]
			[Address(RVA = "0x9E41", Offset = "0x9E41", VA = "0x9E41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005031")]
			[Address(RVA = "0x9E42", Offset = "0x9E42", VA = "0x9E42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001E8 RID: 488
		// (add) Token: 0x06005032 RID: 20530 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005033 RID: 20531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E8")]
		public event Action<SkillSelectorItemView> SelectEvent
		{
			[Token(Token = "0x6005032")]
			[Address(RVA = "0x9E43", Offset = "0x9E43", VA = "0x9E43")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005033")]
			[Address(RVA = "0x9E44", Offset = "0x9E44", VA = "0x9E44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700103D")]
		public List<SkillSelectorItemView> AllItems
		{
			[Token(Token = "0x6005034")]
			[Address(RVA = "0x9E45", Offset = "0x9E45", VA = "0x9E45")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x9E46", Offset = "0x9E46", VA = "0x9E46")]
		private void Awake()
		{
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x9E47", Offset = "0x9E47", VA = "0x9E47")]
		public void Init(List<int> skillIds)
		{
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x9E48", Offset = "0x9E48", VA = "0x9E48")]
		private void ItemOnSelectEvent(SkillSelectorItemView item)
		{
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x9E49", Offset = "0x9E49", VA = "0x9E49")]
		private void Clear()
		{
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x9E4A", Offset = "0x9E4A", VA = "0x9E4A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x9E4B", Offset = "0x9E4B", VA = "0x9E4B")]
		public void Show()
		{
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x9E4C", Offset = "0x9E4C", VA = "0x9E4C")]
		public void Hide()
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x9E4D", Offset = "0x9E4D", VA = "0x9E4D")]
		private void OnCompleteHide()
		{
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x9E4E", Offset = "0x9E4E", VA = "0x9E4E")]
		public SkillSelectorView()
		{
		}

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _content;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _spacer;

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillSelectorItemView _itemPrefab;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x30")]
		private List<SkillSelectorItemView> _allItems;

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x34")]
		private TweenContainer _tweenContainer;
	}
}
