using System;
using System.Collections.Generic;
using Core.Animations;
using DefaultNamespace;
using Il2CppDummyDll;
using Test;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class AnimationTest : MonoBehaviour
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000004")]
	public Toggle PanToggle
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x556D", Offset = "0x556D", VA = "0x556D")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x556E", Offset = "0x556E", VA = "0x556E")]
	private void Awake()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x556F", Offset = "0x556F", VA = "0x556F")]
	private void Start()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x5570", Offset = "0x5570", VA = "0x5570")]
	private void PlayOnceClickHandler()
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x5571", Offset = "0x5571", VA = "0x5571")]
	private void CurrentSpellAnimationOnCompleteEvent(IGameAnimation animation)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x5572", Offset = "0x5572", VA = "0x5572")]
	private void OnFilterInputChanged(string arg0)
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x5573", Offset = "0x5573", VA = "0x5573")]
	private string[] GetCurrentPrefabsArray()
	{
		return null;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x5574", Offset = "0x5574", VA = "0x5574")]
	private void OnTypeAnimationChanged(int arg0)
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x5575", Offset = "0x5575", VA = "0x5575")]
	private void ValidateDropdown()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x5576", Offset = "0x5576", VA = "0x5576")]
	private void ShowButtonClicked()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x5577", Offset = "0x5577", VA = "0x5577")]
	public AnimationTest()
	{
	}

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Button _startButton;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private Button _playOnceButton;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Dropdown _typeDropdown;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Dropdown _dropdown;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InputField _filterInput;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private TMP_InputField _urlInput;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Toggle _panToggle;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x2C")]
	private CanvasGroup _canvasGroup;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _canvasAnimationsContainer;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Transform _worldAnimationsContainer;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationArrayStringData _animationNames;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x3C")]
	private string[] _names;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x40")]
	private AnimationType[] _types;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x44")]
	private bool _isBenchmarkNow;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x48")]
	private AnimationType _currentAnimationType;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private GameObject _animationComponentPrefab;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _testPrefab;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x54")]
	private List<GameObject> _animations;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x58")]
	private AnimationLoaderTest _currentLoader;
}
