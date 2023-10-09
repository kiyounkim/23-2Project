# 🎯Project Convention

### 목차
1. [📢 공지사항](#공지사항)
2. [🎫 Issue 사용법](#issue-convention)
3. [🌿 Branch 사용법](#branch-convention)
4. [📝 커밋 규칙](#커밋-규칙)
5. [🔄 풀 리퀘스트(PR) 가이드라인](#풀-리퀘스트pr-가이드라인)
6. [💻 Git Workflow](#Git-Workflow)

## 공지사항

1. Github webhook이 연동되었습니다.
    - 여러분의 Push, Pull Request, Issue 등의 작업 내용이 github에 접수되면 곧바로 discord의 깃허브 채널에서 확인할 수 있습니다.
2. 작업을 위한 뼈대 파일이 main 브랜치에 추가되었습니다.
    - 작업을 하기 위해, 각자의 작업 폴더에 git clone 명령어를 통해 레포지토리를 복사하신 후 사용하실 수 있습니다.
    - 물론 그 전에 Issue 와 Branch 사용법을 익혀 봅시다.

## Issue Convention

- 이슈는 [Issue Template](https://github.com/kiyounkim/23-2Project/tree/Dev/.github/ISSUE_TEMPLATE.md)이 있습니다. Github 상단의 Issue 탭에서 생성하거나 삭제, 수정이 가능합니다.
- 각 이슈는 번호를 갖고 있습니다. 이 번호를 "이슈 넘버"라고 합니다.
- Assignees에는 본인을 태그하며, Label은 약식으로 Feat, Bug 등 여러 라벨 중, 하나를 골라서 진행합니다.
- Issue 종류
  - Feat : 기능을 개발하는 브랜치, 이슈별/작업별로 브랜치를 생성하여 기능을 개발합니다. 주로 많이 사용합니다.
  - Add: Feat 이외의 라이브러리, scene, asset 추가
  - Remove : 파일 삭제
  - Chore : 기타

### ✍️ 이슈 작성 예시

```markdown
제목: [Feat] MainRecordView에서 말하는 사람을 바꾸기 위한 슬라이드를 구현합니다.

본문:
📝 작업 목적
MainRecordView에서 말하는 사람을 바꿀 수 있도록 슬라이드 구현

🛠️ Tasks
- [ ] 할일 1
- [ ] 할일 2
    - [ ] 할일 2의 서브 태스크
```

## Branch Convention
- Branch: dev를 제외한 모든 브랜치는 하나의 혹은 2개 이상의 Issue에 의해 생성되어야 합니다.
- 각 작업 사항을 작성한 Issue에서 branch를 분기합니다.
- 모든 branch의 source branch는 dev branch입니다.
- ***브랜치 종류/#이슈번호-이슈내용*** 의 양식에 따라 브랜치 이름을 설정합니다.

### 🌿 브랜치 생성 예시
```markdown
Feat/#325-Record-Implement-Slider
```

## 커밋 규칙
```markdown
[Feat/#이슈번호] 구현된 기능
[Add/#이슈번호] 추가한 "파일"
[Remove/#이슈번호] 제거한 "파일"
[Chore/#이슈번호] 기타
```
💡 이슈번호가 일치하는 브랜치에 커밋하는지 확인해주세요!

## 풀 리퀘스트(PR) 가이드라인
PR은 해결하려는 이슈에 연결되어야 합니다.
리포지토리에 제공된 [PR 템플릿](https://github.com/kiyounkim/23-2Project/tree/Dev/.github/PULL_REQUEST_TEMPLATE.md)을 사용하세요.
PR은 병합하기 전에 적어도 한 명 이상의 다른 팀원이 검토해야 합니다.
PR을 병합하기 전에 병합 충돌이 해결되어야 합니다.
PR이 UI 변경과 관련된 경우 PR에 스크린샷을 포함하세요.

```markdown
제목: [Feat/#IssueNumber] 특정 기능 구현

설명:
이 PR은 다음을 구현하여 #IssueNumber 문제를 해결합니다:
- 기능 구현 1
- 기능 2 추가
- 제거된 파일

스크린샷:
스크린샷: [해당되는 경우, 문제를 설명하는 데 도움이 되는 스크린샷을 추가하세요.]
```

## Git Workflow
<img width="690" alt="Screenshot 2023-07-10 at 8 15 34 PM" src="https://github.com/DeveloperAcademy-POSTECH/MC3-Team12-BreakCompany/assets/36729917/66efc12c-4369-4b48-ae3b-017352bc5231">

- 우리는 워크플로우를 위해 Git Flow 전략에서 약간의 변형된 형태를 사용합니다.
- master(main) 브랜치는 HEAD의 소스 코드가 항상 다음 릴리스를 위해 전달된 최신 개발 변경 사항이 있는 상태를 반영하는 주요 브랜치입니다.
- develop 브랜치는 개발이 완료된 최신 브랜치 입니다. 주로 개발된 내역이 병합되는 브랜치에 해당합니다.
- 모든 개발 작업은 develop 브랜치에서 분기된 feature 브랜치에서 이루어져야 합니다.
- 기능이 완료되면 풀 리퀘스트를 통해 develop 브랜치에 다시 병합해야 합니다.
- main 브랜치는 최종 릴리즈 또는 중간 스프린트 이후 반영합니다.

**1. GitHub에 대한 이해:**
GitHub는 버전 관리 시스템인 Git의 호스팅 서비스입니다. GitHub를 이용하면 프로젝트의 소스 코드를 저장하고, 팀원 간에 공유하고, 변경 사항을 추적하며, 필요한 경우 이전 버전으로 롤백하는 것이 가능합니다.

**2. Git 기본 명령어 익히기:**
Git에는 **`clone`**, **`add`**, **`commit`**, **`push`**, **`pull`**, **`branch`**, **`checkout`**, **`merge`** 등 다양한 명령어가 있습니다.
이 명령어들을 이해하고 사용할 수 있어야 원활한 협업이 가능합니다.

**3. GitHub 워크플로우:**

- **`clone`**: GitHub에서 프로젝트를 로컬로 가져오는 것입니다.
- **`branch 생성`**: 각자의 작업 영역을 생성하기 위해 개인 브랜치를 생성합니다. 브랜치는 독립적인 작업 공간이며, 여기서 진행한 작업은 다른 브랜치에 영향을 미치지 않습니다.
- **`add, commit, push`**: 개인 브랜치에서 작업한 후, 이를 add, commit하여 변경 사항을 저장하고, 이를 GitHub에 push합니다.
- **`pull request`**: 개인 브랜치의 작업 내용을 병합하려면, GitHub에서 'pull request'를 생성합니다. 이를 통해 팀원들은 코드 변경 사항을 검토하고, 피드백을 줄 수 있습니다.
- **`merge`**: pull request가 팀원들에게 승인 받으면, 해당 브랜치는 "develop" 브랜치에 병합됩니다.

    **`clone`**: 원격 저장소의 내용을 로컬에 복제합니다. 이를 통해 자신의 컴퓨터에 원격 저장소의 복사본이 생성됩니다.
    `git clone <원격 저장소 URL>`
    
    **`add`**: 변경된 파일을 스테이징 영역에 추가합니다. 스테이징 영역은 커밋이 될 파일들을 대기시키는 장소입니다.
    `git add <파일명>`
    
    **`commit`**: 스테이징 영역에 있는 변경 사항들을 로컬 저장소에 저장합니다. 이는 변경사항을 확정짓는 것이며, 커밋 메시지와 함께 이루어집니다.
    `git commit -m "커밋 메시지”`
    
    **`push`**: 로컬 저장소의 커밋들을 원격 저장소에 업로드합니다. 이를 통해 다른 사람들이 자신의 변경 사항을 볼 수 있게 됩니다.
    `git push <원격 저장소 별명> <브랜치 이름>`
    
    **`pull`**: 원격 저장소의 최신 변경 사항을 로컬로 가져와 병합합니다. 이는 원격 저장소의 변경사항을 자신의 로컬 저장소와 동기화하는데 사용됩니다.
    `git pull <원격 저장소 별명> <브랜치 이름>`
    
    **`branch`**: 새로운 브랜치를 생성하거나 브랜치 목록을 확인합니다. 브랜치는 독립적인 작업 경로를 생성하고, 이를 통해 동일한 소스 코드에 대해 독립적으로 작업이 가능합니다.
    `git branch <새 브랜치 이름>`
    
    **`checkout`**: 특정 브랜치나 커밋으로 이동합니다. 이를 통해 이전 커밋 상태를 확인하거나 다른 브랜치로 작업 환경을 전환할 수 있습니다.
    `git checkout <브랜치 이름 또는 커밋 해시>`
    
    **`merge`**: 한 브랜치의 변경 사항을 다른 브랜치에 병합합니다. 보통 별도의 브랜치에서 작업한 내용을 메인 브랜치에 병합할 때 사용합니다.
    `git merge <병합하려는 브랜치 이름>`

**4. 워크플로우 Ready-to-Go**

**4.1. 프로젝트 클론하기**
    최초에 한 번, 프로젝트를 로컬 시스템에 복제해야 합니다. 이를 위해서는 GitHub에서 프로젝트 URL을 가져와 **`git clone`** 명령을 사용합니다.
    `git clone <프로젝트 URL>`

**4.2. 이슈 생성하고 브랜치 생성하기**
    GitHub 웹사이트에서 우선 작업할 이슈를 생성합니다. 이슈가 생성된 후, 이 이슈와 연관된 브랜치를 생성합니다. 브랜치 이름은 해당 이슈 번호를 반영하는 것이 좋습니다.

**이슈 생성하기**

    1. GitHub 저장소 페이지로 이동합니다.
    2. 페이지 상단의 `"Issues"` 탭을 클릭합니다.
    3. `"New issue"` 버튼을 클릭합니다.
    4. 주어진 템플릿을 기본으로 이슈 제목과 내용을 작성합니다. 제목은 이슈에 대한 간략한 요약이며, 내용은 이슈에 대한 자세한 설명을 적습니다.  라벨, 프로젝트, 담당자(Assigness - 주로 본인이 되겠죠?) 등을 설정할 수도 있습니다.
    5. `"Submit new issue"` 버튼을 클릭하여 이슈를 생성합니다.

**이슈에 연결된 브랜치 생성하기**

    1. 이전에 생성한 이슈 페이지로 이동합니다.
    2. "Create branch"를 클릭합니다.
    3. 새 브랜치의 이름을 입력합니다. 보통 이슈 번호나 이슈 제목을 포함시킵니다.
    4. "Create branch from: master" 옆의 드롭다운 메뉴에서 브랜치를 생성할 기준 브랜치를 선택합니다. 여기에서는 "develop"을 선택하시면 됩니다.
    5. "Create branch" 버튼을 클릭하여 브랜치를 생성합니다.

**4.3. 로컬에 브랜치 체크아웃하기**
    GitHub에서 생성한 브랜치를 로컬에 가져와야 합니다. git checkout` 명령을 사용하여 해당 브랜치로 전환합니다.

**4.4 작업하고 변경 사항 커밋하기**
    소스 코드에서 변경을 한 후에는 `git add` 명령을 사용하여 변경한 파일을 스테이징 영역에 추가하고, `git commit` 명령을 사용하여 변경 사항을 커밋합니다.
    `git add <변경한 파일들>
    git commit -m "<커밋 메시지>"`

**4.5. GitHub에 변경 사항 푸시하기**
    로컬에서 커밋한 변경 사항을 GitHub에 올리려면 `git push` 명령을 사용합니다. (우리는 각자 별도의 feature 브랜치에서 작업하기 때문에, 여기서 말하는 브랜치는 각자의 ‘feature' 브랜치에 해당합니다.)
    
    처음 한 번은 `-u` 옵션을 함께 사용하여 푸시할 원격 저장소와 브랜치를 설정합니다.
    `git push -u origin <브랜치 이름>`
    
    그 다음부터는 간단히 `git push` 명령만 사용하면 됩니다.

**4.6. Pull Request 생성하기**
    GitHub 웹에서 Pull Request를 생성합니다. 이 과정에서, 변경 사항을 검토하고 논의할 수 있습니다. Pull Request는 "develop" 브랜치로 보내져야 합니다.

**4.7. 코드 리뷰와 병합**
    가능한 팀원은 Pull Request를 검토하고 필요한 피드백을 작성합니다. 
    모든 이슈가 해결되고, 충분한 승인을 얻은 후에는 Pull Request를 "develop" 브랜치로 병합(merge)합니다.
    이때, 병합은 셀프머지를 원칙으로 합니다.

**5. 주의사항:**
    💡 항상 작업을 시작하기 전에 `git pull` 명령을 실행하여 최신 변경 사항을 로컬에 반영하고 시작하세요.
    충돌을 방지하는 데 도움이 됩니다.
    
    - 항상 최신 상태를 유지하기 위해 작업을 시작하기 전에 'pull' 명령을 사용하여 변경 사항을 동기화해주세요.
    - 작업을 완료한 후에는 항상 'push' 명령을 사용하여 GitHub에 변경 사항을 반영해주세요.
    - 작업 분리를 위해, 각 작업마다 별도의 브랜치를 사용해주세요.
    - 코드 변경 사항을 잘 문서화하고(이슈 및 PR), 'commit' 메시지는 명확하게 작성해주세요.